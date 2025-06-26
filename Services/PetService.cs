using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestão_Petshop_C_.Dtos;
using Gestão_Petshop_C_.Interfaces;
using Gestão_Petshop_C_.Models;

namespace Gestão_Petshop_C_.Services
{
    public class PetService
    {
        private readonly IPetInterface _repositorio;

        public PetService(IPetInterface repositorio)
        {
            _repositorio = repositorio;
        }


        public void CadastrarPetCliente(PetDTO dto)
        {
            //cadastrar
            Pet newpet = new Pet
            (
                dto.Nome,
                dto.Raca,
                dto.Idade,
                dto.TipoAtual,
                dto.Dono

            );
            _repositorio.CadastrarPetCliente(newpet);
            Console.WriteLine("Pet cadastrado com sucesso.");
        }


        public void ListaPet()
        {
            var lista = _repositorio.ListaPet();
             if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Pet cadastrado!");
            }
            else
            {
                foreach (Pet item in lista)
                {
                    Console.WriteLine($"Nome: {item.Nome} - Raça:{item.Raca} - Idade:{item.Idade} - Tipo: {item.TipoAtual} - Dono: {item.Dono}");
                }
                
            }
        }


        public void Remover(PetDTO dto)
        {
            var buscarPet = _repositorio.ListaPet();
            var petEncontrado = buscarPet.FirstOrDefault(a => a.Nome == dto.Nome); //FirstOrDefault -> busca o primeiro item que satisfaça a condição ou retorna null se não encontrar

            if (petEncontrado != null)
            {
                _repositorio.Remover(petEncontrado);
            }
            else
            {
                Console.WriteLine("Pet não encontrado.");
            }

        }
    }
}