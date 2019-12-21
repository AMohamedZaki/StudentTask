namespace Student.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeUpdatedDateNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Classes", "LastUpdate", c => c.DateTime());
            AlterColumn("dbo.StudentObjs", "LastUpdate", c => c.DateTime());
            AlterColumn("dbo.Departments", "LastUpdate", c => c.DateTime());
            AlterColumn("dbo.Grades", "LastUpdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Grades", "LastUpdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Departments", "LastUpdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StudentObjs", "LastUpdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Classes", "LastUpdate", c => c.DateTime(nullable: false));
        }
    }
}
