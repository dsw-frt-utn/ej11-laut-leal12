using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{

    List<Alumno> lista = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        lista.Add(alumno);
    }

    public void RetornarLista()
    {
        foreach (var Alumno in lista)
        {
            Console.WriteLine(Alumno);
        }
    }

    public Alumno? BuscarAlumno(string nombreBuscar)
    {

        Alumno? a = lista.Find(a => a.Nombre == nombreBuscar);
        Console.WriteLine(a != null ? $"{a.Id}-{a.Nombre}-{a.Promedio}" : "No existe");
        return a;
    }

    public void EliminarAlumno(Alumno alumno)
    {
        lista.Remove(alumno);
    }

    public void EliminarAlumnoIndice(int indice)
    {
        lista.RemoveAt(indice);
    }

}
