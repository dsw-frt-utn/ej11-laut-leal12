using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumno(int legajo,Alumno a)
    {
        if (!alumnos.ContainsKey(legajo))
        {
            alumnos.Add(legajo, a);
        }
    }

    public Alumno BuscarAlumno(int legajoBuscar)
    {
        if (alumnos.ContainsKey(legajoBuscar))
        {
            return alumnos[legajoBuscar];
        }

        return null; 
    }

    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return alumnos;
    }

    public void EliminarAlumno(int legajoEliminar)
    {
        alumnos.Remove(legajoEliminar);
    }

}
