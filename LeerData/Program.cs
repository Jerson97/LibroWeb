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
                var autor = db.Autor.Single(x => x.Nombre == "Paola");
                if (autor != null)
                {
                    autor.Apellidos = "Soto";
                    autor.Grado = "Biologo";
                    var estadoTransaccion = db.SaveChanges();
                    Console.WriteLine("Estado de transaccion ==>" + estadoTransaccion);
                }
            }
        }
    }
}