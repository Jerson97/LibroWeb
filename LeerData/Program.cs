using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new LibrosContext())
            {
                var libros = db.Libro.AsNoTracking();

                foreach (var libro in libros)
                {
                    Console.WriteLine(libro.Titulo + " --- " + libro.Descripcion);
                }
            }
        }
    }
}