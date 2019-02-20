using MVCVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVirtualPets.Repositories
{
    public class PetRepository
    {
        Dictionary<int, Pet> PetDict = new Dictionary<int, Pet>()
            {
                { 1, new Pet("Fido", 1)},
                { 2, new Pet("Fluffy", 2) },
                { 3, new Pet("Zappy", 3) }
            };

        public Dictionary<int, Pet> GetAll()
        {
            return PetDict;
        }

        public Pet GetById(int id)
        {
            return PetDict[id];
        }
    }
}
