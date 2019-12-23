namespace Student.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Address = c.String(),
                        Email = c.String(),
                        Photo = c.Binary(),
                        DepartmentId = c.Int(nullable: false),
                        GradeId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Grades", t => t.GradeId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.GradeId)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentInformations", "GradeId", "dbo.Grades");
            DropForeignKey("dbo.StudentInformations", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.StudentInformations", "ClassId", "dbo.Classes");
            DropIndex("dbo.StudentInformations", new[] { "ClassId" });
            DropIndex("dbo.StudentInformations", new[] { "GradeId" });
            DropIndex("dbo.StudentInformations", new[] { "DepartmentId" });
            DropTable("dbo.Grades");
            DropTable("dbo.Departments");
            DropTable("dbo.StudentInformations");
            DropTable("dbo.Classes");
        }
    }
}
