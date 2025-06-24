using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestão_Petshop_C_.Dtos;
using Gestão_Petshop_C_.Interfaces;
using Gestão_Petshop_C_.Models;

namespace Gestão_Petshop_C_.Services
{
    public class ClienteService
    {
        //pegar a interface para acessar o repositorio fake (igual se fosse uma BD)
        private readonly IClienteInterface _repositorio;

        public ClienteService(IClienteInterface repositorio)
        {
            _repositorio = repositorio;
        }

        public void BuscarCliente(ClienteDTO dto)
        {
            var nome = dto.Nome;
            var busca = _repositorio.BuscarCliente(nome);

            if (busca == null)
            {
                Console.WriteLine("Cliente não encontrado!");
            }
            
        }

        public void CadastrarCliente(ClienteDTO dto)
        {
            bool erros = false;
            //realizar validaçoes
            if (string.IsNullOrWhiteSpace(dto.Nome) || dto.Nome.Length < 3)
            {
                Console.WriteLine("Nome é obrigatorio e pelo menos ter 3 caracteres");
                erros = true;
            }
            else if (dto.Endereco == "")
            {
                Console.WriteLine("Endereço é obrigatorio");
                erros = true;
            }
            else if (dto.Telefone == "")
            {
                Console.WriteLine("Telefone é obrigatorio");
                erros = true;
            }

            if (erros)
            {
                Console.WriteLine("Não foi possivel cadastrar -> [Erros]");
                return;
            }

            //cadastrar
            Cliente newcliente = new Cliente
            (
                dto.Nome,
                dto.Telefone,
                dto.Endereco
            );
            _repositorio.CadastrarCliente(newcliente);
            Console.WriteLine("Cliente cadastrado");
        }

        public void ListaClientes()
        {
            var lista = _repositorio.ListaClientes();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Cliente cadastrado!");
            }
            else
            {
                foreach (Cliente item in lista)
                {
                    Console.WriteLine($"Nome: {item.Nome} - Tel:{item.Telefone} - Endereço:{item.Endereco}");
                }
                
            }
            
        }

        public void Remover(ClienteDTO cliente)
        {
            var buscarCliente = _repositorio.BuscarCliente(cliente.Nome);
            if (buscarCliente == null)
            {
                Console.WriteLine("Nenhum Cliente encontrado!");
            }
            else
            {
                _repositorio.Remover(buscarCliente);
                Console.WriteLine("Cliente removido com sucesso.");
            }

        }
    }
}