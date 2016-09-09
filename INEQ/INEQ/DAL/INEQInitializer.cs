using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using INEQ.Models;

namespace INEQ.DAL
{
    public class INEQInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<INEQContext>
    {
        protected override void Seed(INEQContext context)
        {
            var equipmentypes = new List<EquipmentType>
            {
                new EquipmentType { Description = " Desktop ", UsefulLife = 3, GuaranteeDuration = 1, Active = true },
                new EquipmentType { Description = " Laptop ", UsefulLife = 3, GuaranteeDuration = 1, Active = true },
                new EquipmentType { Description = " Telefono Movil ", UsefulLife = 3, GuaranteeDuration = 1, Active = false },
            };

            equipmentypes.ForEach(s => context.EquipmentTypes.Add(s));
            context.SaveChanges();

            var componenttypes = new List<ComponentType>
            {
                new ComponentType { Description = " CPU", Active = false },
                new ComponentType { Description = " Memoria ", Active = false },
                new ComponentType { Description = " Disco Duro ", Active = false },
                new ComponentType { Description = " Componentes activos ", Active = false },
            };

            componenttypes.ForEach(s => context.ComponentTypes.Add(s));
            context.SaveChanges();
        }
    }
}