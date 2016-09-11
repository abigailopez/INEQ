namespace INEQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ComponentType", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Equipment", "Serie", c => c.String(nullable: false));
            AlterColumn("dbo.Equipment", "SoftekId", c => c.String(nullable: false));
            AlterColumn("dbo.EquipmentType", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EquipmentType", "Description", c => c.String());
            AlterColumn("dbo.Equipment", "SoftekId", c => c.String());
            AlterColumn("dbo.Equipment", "Serie", c => c.String());
            AlterColumn("dbo.ComponentType", "Description", c => c.String());
        }
    }
}
