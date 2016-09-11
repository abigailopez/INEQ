using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ.DAL
{
    public class INEQC: DbC
    {
        public INEQC() : base("INEQC")
            {
            //AQUÍ SE INSERTA LA CADENA DE CONEXIÓN
        }

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Status> Statuses { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
    }
}