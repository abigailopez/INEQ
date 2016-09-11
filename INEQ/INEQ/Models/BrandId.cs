using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ.Models
{
    public class BrandId
    { public int Id { get; set; }
        public String Description { get; set; }
        public Boolean Active { get; set; }

        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}