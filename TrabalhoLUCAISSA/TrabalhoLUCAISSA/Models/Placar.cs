using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoLUCAISSA.Models
{
    public class Placar
    {

        public int PlacarID { get; set; }
        [Required]
        public int JogadorID { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public int Pontuacao { get; set; }
        public Jogador Jogador { get; set; }

    }
}
