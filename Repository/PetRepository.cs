using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestão_Petshop_C_.Interfaces;
using Gestão_Petshop_C_.Models;

namespace Gestão_Petshop_C_.Repository
{
    public class PetRepository : IPetInterface
    {
        List<Pet> pets = new List<Pet>();

        //cadastrar um pet e associar ao cliente
        public void CadastrarPetCliente(Pet pet)
        {
            pets.Add(pet);
        }

        //lista pets
        public List<Pet> SoPet()
        {
            return pets;
        }

        //listar pets com os donos
        public List<Pet> ListaPet()
        {
            return pets;
        }

        //remover um pet

        public void Remover(Pet pet)
        {
            pets.Remove(pet);
        }


    }
}