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
        public TrabalhoLUCAISSAContext (DbContextOptions<TrabalhoLUCAISSAContext> options)
            : base(options)
        {
        }

        public DbSet<TrabalhoLUCAISSA.Models.Jogador> Jogador { get; set; }

        public DbSet<TrabalhoLUCAISSA.Models.Placar> Placar { get; set; }
    }
}
