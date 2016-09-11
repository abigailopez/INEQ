using INEQ.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace INEQ.DAL
{
    public class INEQContext : DbContext
    {
        public INEQContext() : base("INEQContext")
            {
                //AQUÍ SE INSERTA LA CADENA DE CONEXIÓN
            }

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<ComponentType> ComponentTypes { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}