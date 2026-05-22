using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> diccionarioAlumnos;

    public CasoDictionary()
    {
        diccionarioAlumnos = new Dictionary<int, Alumno>();
    }

    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        if (!diccionarioAlumnos.ContainsKey(legajo))
        {
            diccionarioAlumnos.Add(legajo, alumno);
        }
        else
        {
            Console.WriteLine("Error: Ya existe un alumno con ese legajo.");
        }
    }

    public Alumno? BuscarAlumnoPorLegajo(int legajo)
    {
        if (diccionarioAlumnos.ContainsKey(legajo))
        {
            return diccionarioAlumnos[legajo];
        }
        return null;
    }

    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return diccionarioAlumnos;
    }

    public void EliminarAlumno(int legajo)
    {
        if (diccionarioAlumnos.ContainsKey(legajo))
        {
            diccionarioAlumnos.Remove(legajo);
        }
        else
        {
            Console.WriteLine("No se encontró un alumno con ese legajo para eliminar.");
        }
    }
}
