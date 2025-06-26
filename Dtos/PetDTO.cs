using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestão_Petshop_C_.Models;
using static Gestão_Petshop_C_.Models.Pet;

namespace Gestão_Petshop_C_.Dtos
{
    public class PetDTO
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public Tipo TipoAtual { get; set; }
        public int Idade { get; set; }
        
    }
}