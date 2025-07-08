using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestão_Petshop_C_.Models;

namespace Gestão_Petshop_C_.Interfaces
{
    public interface IPetInterface
    {
        
        void CadastrarPetCliente(Pet pet);
        List<Pet> ListaPet();
        List<Pet> SoPet();
        void Remover(Pet pet);

    }
}