using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestão_Petshop_C_.Models
{
    public class Cliente
    {
  
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        //construtor
        public Cliente(string nome, string telefone, string endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

    }
}