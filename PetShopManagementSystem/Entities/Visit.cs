using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopManagementSystem.Entities
{
    public class Visit
    {
        public int VisitId { get; set; }
        public DateTime VisitDate { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner {get; set; }


    }
}
