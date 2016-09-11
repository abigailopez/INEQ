using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ.DAL
{
    
        public class INEQI : System.Data.Entity.DropCreateDatabaseIfModelChanges<INEQC>
    {
        protected override void Seed(INEQC c)
        {
            var statuses = new List<Status>
                {
                     new EquipmentType { Description = " Asignado ", UsefulLife = 3, GuaranteeDuration = 1, Active = true },
                new EquipmentType { Description = " Sin asignar ", UsefulLife = 3, GuaranteeDuration = 1, Active = true },
                new EquipmentType { Description = " Pre asignado ", UsefulLife = 3, GuaranteeDuration = 1, Active = true },
            };

            statuses.ForEach(s => c.Statuses.Add(s));
            c.SaveChanges();

        }
    }
}


