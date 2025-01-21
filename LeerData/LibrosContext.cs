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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LibroAutor>().HasKey(x => new {x.AutorId, x.LibroId});
        }

        public DbSet<Libro> Libro {get; set;}
        public DbSet<Precio> Precio {get; set;}
        public DbSet<Comentario> Comentario {get; set;}
        public DbSet<Autor> Autor {get; set;}
        public DbSet<LibroAutor> LibroAutor {get; set;}
    }

}