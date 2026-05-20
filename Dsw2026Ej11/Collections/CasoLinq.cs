namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
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
    List<Libro> libros = new List<Libro>();

    public CasoLinq()
    {
        libros = Libro.CrearLista();
    }

    public Libro GetPrimero()
    {
        var consulta = from l in libros
                       select l;
        return consulta.ToList()[0];
    }
    public Libro GetUltimo()
    {
        var consulta = (from l in libros
                       select l).ToList();
        return consulta[consulta.Count - 1];
    }
      
    public decimal GetTotalPrecios()
    {
        var consultaPrecios = from l in libros
                              select l.Precio;

        return consultaPrecios.Sum();
    }

    public decimal GetPromedioPrecios()
    {
        var consultaPrecios = from l in libros
                              select l.Precio;

        return consultaPrecios.Sum()/consultaPrecios.Count();
    }

    public List<Libro> GetListById()
    {
        var consulta = from l in libros
                       where l.Id > 15
                       select l;
        return consulta.ToList();
    }

    public List<string> GetLibros()
    {
        var consultaStrings = from l in libros
                              select $"{l.Titulo} - {l.Precio:C0}";

        return consultaStrings.ToList();
    }

    public Libro GetMayorPrecio()
    {
        var consultaOrdenada = from l in libros
                               orderby l.Precio descending
                               select l;

        return consultaOrdenada.ToList()[0];
    }

    public Libro GetMenorPrecio()
    {
        var consultaOrdenada = from l in libros
                               orderby l.Precio ascending
                               select l;

        return consultaOrdenada.ToList()[0];
    }

    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = GetPromedioPrecios();
        var consulta = from l in libros
                       where l.Precio > promedio
                       select l;

        return consulta.ToList();
    }

    public List<Libro> GetLibrosOrdenados()
    {
        var consulta = from l in libros
                       orderby l.Titulo descending
                       select l;

        return consulta.ToList();
    }


}
