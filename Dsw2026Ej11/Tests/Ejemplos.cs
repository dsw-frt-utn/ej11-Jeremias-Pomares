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

        var casoList = new CasoList();

        var alumno1 = new Alumno (20,"Juan",8.5d );
        casoList.AgregarAlumno(alumno1);
        var alumno2 = new Alumno (21,"Ana",9.0d );
        casoList.AgregarAlumno(alumno2);
        var alumno3 = new Alumno (22,"Luis",7.5d );
        casoList.AgregarAlumno(alumno3);

        Console.WriteLine("¿El alumno Ana esta en la lista?");
        Console.WriteLine(casoList.BuscarAlumnoPorNombre("Ana")?.ToString());

        Console.WriteLine("¿El alumno Pedro esta en la lista?");
        Console.WriteLine(casoList.BuscarAlumnoPorNombre("Pedro")?.ToString() ?? "No existe");

        casoList.EliminarAlumno(alumno1);
        Console.WriteLine("Alumnos después de eliminar a Juan:");
        foreach (var alumno in casoList.ObtenerListaAlumnos())
        {
            Console.WriteLine(alumno.ToString());
        }

        Console.WriteLine("Alumnos después de eliminar el primer elemento:");
        casoList.EliminarAlumnoPorPosicion(0);

        foreach (var alumno in casoList.ObtenerListaAlumnos())
        {
            Console.WriteLine(alumno.ToString());
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();
        var alumno1 = new Alumno (40,"Jeremias",5.6d );
        var alumno2 = new Alumno (53,"Sofia",9.8d );
        var alumno3 = new Alumno (66,"Agustin",6.5d );

        casoDictionary.AgregarAlumno(45667823, alumno1);
        casoDictionary.AgregarAlumno(98765432, alumno2);
        casoDictionary.AgregarAlumno(12345678, alumno3);

        Console.WriteLine("¿El alumno con legajo 98765432 existe?:");
        Console.WriteLine(casoDictionary.BuscarAlumnoPorLegajo(98765432)?.ToString());
        Console.WriteLine("¿El alumno con legajo 11111111 existe?:");
        Console.WriteLine(casoDictionary.BuscarAlumnoPorLegajo(11111111)?.ToString() ?? "No existe");
        Console.WriteLine("Alumnos después de eliminar el alumno con legajo 45667823:");
        casoDictionary.EliminarAlumno(45667823);
        foreach (var alumno in casoDictionary.ObtenerDiccionario())
        {
            Console.WriteLine(alumno.ToString());
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq(Libro.CrearLista());

        Console.WriteLine("Primer libro:");
        Console.WriteLine(casoLinq.GetPrimero()?.Titulo);

        Console.WriteLine("Último libro:");
        Console.WriteLine(casoLinq.GetUltimo()?.Titulo);

        Console.WriteLine("Total de precios:");
        Console.WriteLine(casoLinq.GetTotalPrecios());

        Console.WriteLine("Promedio de precios:");
        Console.WriteLine(casoLinq.GetPromedioPrecios());

        Console.WriteLine("Libros con id mayor a 15:");
        foreach (var libro in casoLinq.GetListById())
        {
            Console.WriteLine(libro.Titulo);
        }

        Console.WriteLine("lista de string (título y precio moneda)");
        foreach (var libro in casoLinq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("Libro con mayor precio:");
        Console.WriteLine(casoLinq.GetMayorPrecio()?.Titulo);

        Console.WriteLine("Libro con menor precio:");
        Console.WriteLine(casoLinq.GetMenorPrecio()?.Titulo);

        Console.WriteLine("Libros con precio mayor al promedio:");
        foreach (var libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine(libro.Titulo);
        }

        Console.WriteLine("Libros ordenados por titulo descendente:");
        foreach (var libro in casoLinq.GetOrdenadosDesc())
        {
            Console.WriteLine(libro.Titulo);
        }
    }
}
