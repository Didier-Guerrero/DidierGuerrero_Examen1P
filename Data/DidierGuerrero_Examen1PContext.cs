using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DidierGuerrero_Examen1P.Models;

namespace DidierGuerrero_Examen1P.Data
{
    public class DidierGuerrero_Examen1PContext : DbContext
    {
        public DidierGuerrero_Examen1PContext (DbContextOptions<DidierGuerrero_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<DidierGuerrero_Examen1P.Models.DidierGuerrero__Tabla> DidierGuerrero__Tabla { get; set; } = default!;
    }
}
