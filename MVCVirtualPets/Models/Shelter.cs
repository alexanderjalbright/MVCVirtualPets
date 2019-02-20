using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVirtualPets.Models
{
    public class Shelter
    {
        public Dictionary<int, Pet> PetDict { get; private set; }

        public Shelter()
        {
            PetDict = new Dictionary<int, Pet>()
            {
                { 1, new Pet("Fido", 1)},
                { 2, new Pet("Fluffy", 2) },
                { 3, new Pet("Zappy", 3) }
            };
        }
    }
}
