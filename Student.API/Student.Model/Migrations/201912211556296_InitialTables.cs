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
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentObjs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Address = c.String(),
                        Email = c.String(),
                        Photo = c.Binary(),
                        DepartmentId = c.Int(nullable: false),
                        GradeId = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        Classes__Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Classes__Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Grades", t => t.GradeId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.GradeId)
                .Index(t => t.Classes__Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentObjs", "GradeId", "dbo.Grades");
            DropForeignKey("dbo.StudentObjs", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.StudentObjs", "Classes__Id", "dbo.Classes");
            DropIndex("dbo.StudentObjs", new[] { "Classes__Id" });
            DropIndex("dbo.StudentObjs", new[] { "GradeId" });
            DropIndex("dbo.StudentObjs", new[] { "DepartmentId" });
            DropTable("dbo.Grades");
            DropTable("dbo.Departments");
            DropTable("dbo.StudentObjs");
            DropTable("dbo.Classes");
        }
    }
}
