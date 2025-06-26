using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestão_Petshop_C_.Models
{
    public class PetExotico : Pet
    {
        public string Origem { get; set; }

        public PetExotico(string nome, string raca, int idade, Tipo tipoatual, Cliente dono, string origem) : base(nome, raca, idade, tipoatual, dono)
        {
            Origem = origem;
        }
    }
}