namespace INEQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ComponentType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Equipment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EquipmentId = c.Int(nullable: false),
                        ModelId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        WarehouseId = c.Int(nullable: false),
                        EntryDate = c.DateTime(nullable: false),
                        Serie = c.String(),
                        SoftekId = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EquipmentType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        UsefulLife = c.Single(nullable: false),
                        GuaranteeDuration = c.Single(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Equipment_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Equipment", t => t.Equipment_ID)
                .Index(t => t.Equipment_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EquipmentType", "Equipment_ID", "dbo.Equipment");
            DropIndex("dbo.EquipmentType", new[] { "Equipment_ID" });
            DropTable("dbo.EquipmentType");
            DropTable("dbo.Equipment");
            DropTable("dbo.ComponentType");
        }
    }
}
