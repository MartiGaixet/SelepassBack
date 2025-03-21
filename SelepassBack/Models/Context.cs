using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace SelepassBack.Models
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Apuntes> Apuntes { get; set; }
        public DbSet<Examen> Examenes { get; set; }
        public DbSet<Aviso> Avisos { get; set; }
        public DbSet<ExUser> ExUsers { get; set; }
        public DbSet<ApuntesUser> ApuntesUsers { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
            {

            }
        
    }
}

