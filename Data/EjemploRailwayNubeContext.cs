using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EjemploRailwayNube.Entidades;

namespace EjemploRailwayNube.Data
{
    public class EjemploRailwayNubeContext : DbContext
    {
        public EjemploRailwayNubeContext (DbContextOptions<EjemploRailwayNubeContext> options)
            : base(options)
        {
        }

        public DbSet<EjemploRailwayNube.Entidades.Persona> Persona { get; set; } = default!;
    }
}
