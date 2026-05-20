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

        //devolver la lista
        cl.RetornarLista();
        Console.WriteLine("");

        //buscar por nombre
        cl.BuscarAlumno("Leal");

        //alumno q no existe
        cl.BuscarAlumno("no existe");

        //eliminar alumno
        cl.EliminarAlumno(a3);
        cl.RetornarLista();

        //eliminar 1er elemento
        cl.EliminarAlumnoIndice(0);
        cl.RetornarLista();
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
