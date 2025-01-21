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
                var nuevoAutor = new Autor {
                    Nombre = "Pedro",
                    Apellidos = "Paredes",
                    Grado = "Master"
                };
                
                db.Add(nuevoAutor);

                var nuevoAutor2 = new Autor {
                    Nombre = "Palola",
                    Apellidos = "Martinez",
                    Grado = "Master"
                };
                
                db.Add(nuevoAutor2);

                var estadoTransaccion = db.SaveChanges();
                Console.WriteLine("Estado de transaccion ===>" + estadoTransaccion);

                
            }
        }
    }
}