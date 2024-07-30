using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagementSystem.Entities
{
    public class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public ICollection<PetSpecialization> PetsSpecialization { get; set; }
    }
}
