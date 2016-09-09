using INEQ.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace INEQ.DAL
{
    public class INEQContext : DbContext
    {
        public INEQContext() : base("INEQ Context")
            {
                //AQUÍ SE INSERTA LA CADENA DE CONEXIÓN
            }

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<ComponentType> ComponentTypes { get; set; }
        /*
         * AQUÍ SE AGREGARÁN EL RESTO DE LAS TABLAS. 
         * SERÁ LA MISMA ESTRUCTURA QUE LAS ANTERIORES, REEMPLAZANDO EL NOMBRE DE LAS TABLAS.
         */

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}