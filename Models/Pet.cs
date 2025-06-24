using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestão_Petshop_C_.Models
{
    public class Pet
    {
        public string Nome { get; set; }
        public string Raça { get; set; }
        public enum Tipo
        {
            Cachorro,
            Gato,
            Pássaro,
            Galinha
        }
        public int Idade { get; set; }
    }
}