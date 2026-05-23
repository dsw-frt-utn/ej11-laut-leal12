using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList cl = new CasoList();
        Alumno a1 = new Alumno(1, "Leal", 9.5);
        Alumno a2 = new Alumno(2, "Alicata", 8.4);
        Alumno a3 = new Alumno(3, "Vicente", 5.7);
        cl.AgregarAlumno(a1);
        cl.AgregarAlumno(a2);
        cl.AgregarAlumno(a3);

        Console.WriteLine("lista de Alumnos");
        cl.RetornarLista();
        Console.WriteLine("");

        Console.WriteLine("Buscar alumno por nombre (Leal)");
        cl.BuscarAlumno("Leal");

        Console.WriteLine("Buscar alumno que no existe (Juan)");
        cl.BuscarAlumno("Juan");
        Console.WriteLine("");

        Console.WriteLine("Eliminar alumno ");
        cl.EliminarAlumno(a3);
        cl.RetornarLista();
        Console.WriteLine("");

        Console.WriteLine("Eliminar primer elemento de la lista");
        cl.EliminarAlumnoIndice(0);
        cl.RetornarLista();
        Console.WriteLine("");
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary cd = new CasoDictionary();

        Alumno a1 = new Alumno(1, "Leal", 9.5);
        Alumno a2 = new Alumno(2, "Alicata", 8.4);
        Alumno a3 = new Alumno(3, "Vicente", 5.7);

        cd.AgregarAlumno(10, a1);
        cd.AgregarAlumno(20, a2);
        cd.AgregarAlumno(30, a3);

        Console.WriteLine("Lista de Alumnos");
        Dictionary<int, Alumno> todos = cd.RetornarDiccionario();
        foreach (KeyValuePair<int, Alumno> par in todos)
        {
            Console.WriteLine($"Legajo:{par.Key} - ID:{par.Value.Id} - Nombre:{par.Value.Nombre} - Promedio:{par.Value.Promedio}");
        }
        Console.WriteLine("");

        Console.WriteLine("Buscar alumno por legajo (20)");
        Alumno alBuscado = cd.BuscarAlumno(20);
        if ( alBuscado != null)
        {
            Console.WriteLine($"Alumno -> ID:{alBuscado.Id} - Nombre:{alBuscado.Nombre} - Promedio:{alBuscado.Promedio}");
        }
        Console.WriteLine("");
        Console.WriteLine("Buscar Alumno que no existe (99)");
        Alumno alNoExiste = cd.BuscarAlumno(99);
        if (alNoExiste == null)
        {
            Console.WriteLine("El alumno no existe");
        }
        Console.WriteLine("");

        Console.WriteLine("Eliminar alumno por legajo (30)");
        cd.EliminarAlumno(30);
        Dictionary<int, Alumno> listaActualizada = cd.RetornarDiccionario();
        foreach (var par in listaActualizada) 
        {
            Console.WriteLine($"Legajo:{par.Key} - ID:{par.Value.Id} - Nombre:{par.Value.Nombre} - Promedio:{par.Value.Promedio}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq clq = new CasoLinq();

        Console.WriteLine("Primer libro");
        Libro primero =clq.GetPrimero();
        Console.WriteLine($"ID:{primero.Id} - Titulo:{primero.Titulo} - Precio:{primero.Precio:C0}");
        Console.WriteLine("");

        Console.WriteLine("Ultimo libro");
        Libro ultimo=clq.GetUltimo();
        Console.WriteLine($"ID:{ultimo.Id} - Titulo:{ultimo.Titulo} - Precio:{ultimo.Precio:C0}");
        Console.WriteLine("");

        Console.WriteLine("Suma de precios de los libros");
        decimal total = clq.GetTotalPrecios();
        Console.WriteLine($"Suma de precios:{total:C0}");
        Console.WriteLine("");

        Console.WriteLine("Promedio de precio de los libros");
        decimal prom=clq.GetPromedioPrecios();
        Console.WriteLine($"Promedio:{prom:C0}");
        Console.WriteLine("");

        Console.WriteLine("Libros con ID mayor a 15");
        var listaid15 = clq.GetListById();
        foreach(Libro l in listaid15)
        {
            Console.WriteLine($"ID:{l.Id} - Titulo:{l.Titulo} - Precio:{l.Precio}");

        }
        Console.WriteLine("");

        Console.WriteLine("Lista de libros");
        var listalibros = clq.GetLibros();
        foreach (string l in listalibros)
        {
            Console.WriteLine(l);

        }
        Console.WriteLine("");

        Console.WriteLine("Libro mas caro");
        Libro mascaro = clq.GetMayorPrecio();
        Console.WriteLine($"ID:{mascaro.Id} - Titulo:{mascaro.Titulo} - Precio:{mascaro.Precio}");
        Console.WriteLine("");

        Console.WriteLine("Libro mas barato");
        Libro masbarato = clq.GetMenorPrecio();
        Console.WriteLine($"ID:{masbarato.Id} - Titulo:{masbarato.Titulo} - Precio:{masbarato.Precio}");
        Console.WriteLine("");

        Console.WriteLine("Lista de libros ordenada por titulo Z-A");
        var listaord = clq.GetLibrosOrdenados();
        foreach(Libro l in listaord)
        {
            Console.WriteLine($"ID:{l.Id} - Titulo:{l.Titulo} - Precio:{l.Precio:C0}");
        }

    }
}
