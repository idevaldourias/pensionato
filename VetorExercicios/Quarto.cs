using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorExercicios
{
    internal class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroQuarto { get; set; }
        public override string ToString()
        {
            return NumeroQuarto + ": " + Nome + ", " + Email; 
        }
    }
}
