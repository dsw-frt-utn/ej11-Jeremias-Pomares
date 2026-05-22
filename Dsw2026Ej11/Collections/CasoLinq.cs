using Dsw2026Ej11.Domain;
using System.Globalization;

namespace Dsw2026Ej11.Collections;


/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> libros;

    public CasoLinq(List<Libro> listaLibros)
    {
        libros = listaLibros;
    }

    // 1. Obtener el primer libro
    public Libro GetPrimero() => libros.FirstOrDefault();

    // 2. Obtener el último libro
    public Libro GetUltimo() => libros.LastOrDefault();

    // 3. Obtener la suma de precios
    public decimal GetTotalPrecios() => libros.Sum(l => l.Precio);

    // 4. Obtener el promedio de precios
    public double GetPromedioPrecios() => (double)libros.Average(l => l.Precio);

    // 5. Obtener la lista de libros con Id mayor a 15
    public IEnumerable<Libro> GetListById() => libros.Where(l => l.Id > 15);

    // 6. Obtener lista de string (título y precio moneda)
    public IEnumerable<string> GetLibros() =>
        libros.Select(l => $"{l.Titulo} - {l.Precio.ToString("C", new CultureInfo("es-AR"))}");
    // 7. Obtener el libro con el precio más alto
    public Libro GetMayorPrecio() => libros.OrderByDescending(l => l.Precio).FirstOrDefault();

    // 8. Obtener el libro con el precio más bajo
    public Libro GetMenorPrecio() => libros.OrderBy(l => l.Precio).FirstOrDefault();

    // 9. Obtener los libros cuyo precio sea mayor al promedio
    public IEnumerable<Libro> GetMayorPromedio()
    {
        var promedio = libros.Average(l => l.Precio);
        return libros.Where(l => l.Precio > (decimal)promedio);
    }

    // 10. Obtener los libros ordenados por título de forma descendente
    public IEnumerable<Libro> GetOrdenadosDesc() => libros.OrderByDescending(l => l.Titulo);
}
