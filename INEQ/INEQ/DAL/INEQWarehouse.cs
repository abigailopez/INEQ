using INEQ.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace INEQ.DAL
{
    public class INEQWarehouse : DbContext
    {
        public INEQWarehouse() : base ("INEQWarehouse")
            {
            //AQUÍ SE INSERTA LA CADENA DE CONEXIÓN
        }

        public DbSet<Warehouse> Equipments { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Warehouse> ComponentTypes { get; set; }


        void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    
}
}