using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ.Models
{
    public class Model
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public Boolean Active { get; set; }

        public virtual ICollection<BrandId> BrandIds { get; set; }
    }
}