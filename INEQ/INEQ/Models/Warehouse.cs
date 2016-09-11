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
        public float UsefulLife { get; set; }
        public float GuaranteeDuration { get; set; }
        public Boolean active { get; set; }

    }
}