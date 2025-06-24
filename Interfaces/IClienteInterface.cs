using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestão_Petshop_C_.Models;

namespace Gestão_Petshop_C_.Interfaces
{
    public interface IClienteInterface
    {
        void CadastrarCliente(Cliente cliente);
        List<Cliente> ListaClientes();
        Cliente BuscarCliente(string nome);
        void Remover(Cliente cliente);

    }
}