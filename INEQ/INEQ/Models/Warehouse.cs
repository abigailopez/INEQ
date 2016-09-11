using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public String Is { get; set; }
        public string Responsable { get; set; }
    
        public Boolean Active { get; set; }

        public virtual ICollection<EquipmentType> EquipmentTypes { get; set; }



    }
}