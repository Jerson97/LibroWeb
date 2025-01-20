using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class LibrosContext : DbContext
    {
        private const string connectionString = @"Data Source=DESKTOP-OLNCKLF\MSSQLSERVER01;Initial Catalog=LibrosWeb;user id=sa;password=sql;TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
        .UseSqlServer(connectionString)
        .EnableSensitiveDataLogging(); 
        }

        public DbSet<Libro> Libro {get; set;}
    }

}