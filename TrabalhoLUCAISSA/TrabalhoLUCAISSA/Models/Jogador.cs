using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoLUCAISSA.Models
{
    public class Jogador
    {
        public int JogadorID { get; set; }
        [Required]
        public int Idade { get; set; }
        [Required]
        public String Nome { get; set; }
        public String Nacionalidade { get; set; }


    }
}
