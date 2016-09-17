namespace ContosoUniversityAPI2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Creditos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Enrolamiento",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CursoID = c.Int(nullable: false),
                        EstudianteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Curso", t => t.CursoID, cascadeDelete: true)
                .ForeignKey("dbo.Estudiante", t => t.EstudianteID, cascadeDelete: true)
                .Index(t => t.CursoID)
                .Index(t => t.EstudianteID);
            
            CreateTable(
                "dbo.Estudiante",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        FechaEnrolamiento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrolamiento", "EstudianteID", "dbo.Estudiante");
            DropForeignKey("dbo.Enrolamiento", "CursoID", "dbo.Curso");
            DropIndex("dbo.Enrolamiento", new[] { "EstudianteID" });
            DropIndex("dbo.Enrolamiento", new[] { "CursoID" });
            DropTable("dbo.Estudiante");
            DropTable("dbo.Enrolamiento");
            DropTable("dbo.Curso");
        }
    }
}
