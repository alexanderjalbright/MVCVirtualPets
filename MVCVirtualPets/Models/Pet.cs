using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVirtualPets.Models
{
    public class Pet
    {
        public Pet(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; private set; }

        public int Id { get; private set; }
    }
}
