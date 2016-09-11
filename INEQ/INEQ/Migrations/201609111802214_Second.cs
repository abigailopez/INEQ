namespace INEQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Warehouse");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Warehouse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        UsefulLife = c.Single(nullable: false),
                        GuaranteeDuration = c.Single(nullable: false),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
