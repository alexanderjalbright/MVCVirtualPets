using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVirtualPets.Models
{
    public class Pet
    {
        public Pet(string name)
        {
            Name = name;
        }

        public Pet()
        {

        }

        public string Name { get; set; }
    }
}
