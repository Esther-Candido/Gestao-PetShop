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


        public void CadastrarPetCliente(PetDTO dto, Cliente cliente)
        {
            //cadastrar
            Pet newpet = new Pet
            (
                dto.Nome,
                dto.Raca,
                dto.Idade,
                dto.TipoAtual,
                cliente

            );
            _repositorio.CadastrarPetCliente(newpet);
            Console.WriteLine("Pet cadastrado com sucesso.");
        }


        public List<Pet> ListaPet()
        {
            return _repositorio.ListaPet();
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