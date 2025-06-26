using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestão_Petshop_C_.Models
{
    public enum Tipo
    {
        Cachorro,
        Gato,
        Pássaro,
        Galinha
    }

    public class Pet
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public Tipo TipoAtual { get; set; }
        public int Idade { get; set; }
        public Cliente Dono { get; set; }

        public Pet(string nome, string raca, int idade, Tipo tipoatual, Cliente dono)
        {
            Nome = nome;
            Raca = raca;
            Idade = idade;
            TipoAtual = tipoatual;
            Dono = dono;
        }
    }
}