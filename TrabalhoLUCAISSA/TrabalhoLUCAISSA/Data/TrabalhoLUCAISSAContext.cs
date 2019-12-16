using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrabalhoLUCAISSA.Models;

namespace TrabalhoLUCAISSA.Models
{
    public class TrabalhoLUCAISSAContext : DbContext
    {
        public static DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder<TrabalhoLUCAISSAContext>();
        public TrabalhoLUCAISSAContext() : base(optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CompeticaoDB;Trusted_Connection=True;").Options)
        {

        }

        public DbSet<TrabalhoLUCAISSA.Models.Jogador> Jogador { get; set; }

        public DbSet<TrabalhoLUCAISSA.Models.Placar> Placar { get; set; }
    }
}
