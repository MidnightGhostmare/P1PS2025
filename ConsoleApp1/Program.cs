// See https://aka.ms/new-console-template for more information
using System.Data.Common;

var tipo1 = new TiposUsuarios(1, "Admin");
var tipo2 = new TiposUsuarios(2, "Normal");

List<TiposUsuarios> listaTipoU = new List<TiposUsuarios>();
listaTipoU.Add(tipo1);
listaTipoU.Add(tipo2);

var nom = "Hank";
Usuarios obju1 = new Usuarios(1, "Pepito", "Perez", DateTime.Now, 30.0, true, tipo1);
Usuarios obju2 = new Usuarios(2, "Juanito", "Gonzales", DateTime.Now, 35.0, true, tipo2);
var obju3 = new Usuarios(3, nom, "Gomez", DateTime.Now, 40.0, true, new TiposUsuarios(3, "Estudiante"));
List<Usuarios> listaU = new List<Usuarios>();
listaU.Add(obju1);
listaU.Add(obju2);
listaU.Add(obju3);

//TiposUsuarios? objid = lista.FirstOrDefault(x => x.Id == 1);
var objid = listaTipoU.FirstOrDefault(x => x.Id == 1);
if (objid != null)
{
    Console.WriteLine(objid.Nombre);
}else{
    Console.WriteLine("No se encontraron tipos de usuario con esta id");
}

String msj = "Los usuarios menores a 45 y mayores a 30 es/son:\n";
List<Usuarios> listaAux = listaU.FindAll(x => x.Edad<45 && x.Edad>30);
foreach (Usuarios j in listaAux)
{
    msj = msj+j.Nombre+" "+j.Apellido+", ID: "+j.Id+"\n";       
}

Console.WriteLine(msj);

public class Usuarios
{
    private int id;
    private string? nombre = null;
    private string? apellido = null;
    private DateTime fecha;
    private double edad;
    private bool genero;
    private TiposUsuarios? tipo;

    public Usuarios(int id, string? nombre, string? apellido, DateTime fecha, double edad, bool genero, TiposUsuarios? tipo)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        Fecha = fecha;
        Edad = edad;
        Genero = genero;
        Tipo = tipo;
    }

    public int Id {get=>id;set=>id=value;}
    public String? Nombre { get=>nombre;set=>nombre=value;}
    public String? Apellido { get=>apellido;set=>apellido=value;}
    public DateTime Fecha {get=>fecha;set=>fecha=value;}
    public double Edad { get => edad; set => edad = value; }
    public bool Genero { get => genero; set => genero = value; }
    public TiposUsuarios? Tipo { get => tipo; set => tipo = value; }
}

public class TiposUsuarios
{
    private int id;
    private string? nombre = null;

    public int Id { get => id; set => id = value; }
    public string? Nombre { get => nombre; set => nombre = value; }

    public TiposUsuarios()
    {

    }

    public TiposUsuarios(int id, string? nombre)
    {
        Id = id;
        Nombre = nombre;
    }
}