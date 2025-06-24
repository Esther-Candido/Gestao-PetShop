using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestão_Petshop_C_.Interfaces;
using Gestão_Petshop_C_.Models;

namespace Gestão_Petshop_C_.Repository
{
    public class ClienteRepository : IClienteInterface
    {
        //acessar a lista de clientes 
        private List<Cliente> clientes = new List<Cliente>();

        
        public Cliente BuscarCliente(string nome)
        {
            return clientes.Find(a => a.Nome == nome);
        }

        public void CadastrarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public List<Cliente> ListaClientes()
        {
            return clientes;
        }

        public void Remover(Cliente cliente)
        {
            clientes.Remove(cliente);
        }
    }
}