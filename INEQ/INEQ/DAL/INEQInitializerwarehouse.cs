using INEQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ.DAL
{
    public class INEQInitializerwarehouse : System.Data.Entity.DropCreateDatabaseIfModelChanges<INEQContext>
    {
        protected override void Seed(INEQContext context)
        {
            var equipmentypes = new List<EquipmentType>
            {
                new EquipmentType { Description = " Monterrey ", UsefulLife = 3, GuaranteeDuration = 1, Active = true },
                new EquipmentType { Description = " Ensenada ", UsefulLife = 3, GuaranteeDuration = 1, Active = true },
                new EquipmentType { Description = " Mexico DF ", UsefulLife = 3, GuaranteeDuration = 1, Active = true },
            };

            equipmentypes.ForEach(s => context.EquipmentTypes.Add(s));
            context.SaveChanges();




        }
    }
}