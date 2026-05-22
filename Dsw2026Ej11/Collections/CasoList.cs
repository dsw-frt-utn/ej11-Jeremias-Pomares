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
    private List<Alumno> listaAlumnos;

    public CasoList()
    {
        listaAlumnos = new List<Alumno>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        listaAlumnos.Add(alumno);
    }

    public List<Alumno> ObtenerListaAlumnos()
    {
        return listaAlumnos;
    }

    public Alumno? BuscarAlumnoPorNombre(string nombre)
    {
        foreach (Alumno alumno in listaAlumnos)
        {
            if (alumno.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                return alumno;
            }
        }
        return null;
    }

    public void EliminarAlumno(Alumno alumno)
    {
        listaAlumnos.Remove(alumno);
    }

    public void EliminarAlumnoPorPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < listaAlumnos.Count)
        {
            listaAlumnos.RemoveAt(posicion);
        }
        else
        {
            Console.WriteLine("La posición indicada no es válida.");
        }
    }
}
