namespace Student.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixNameType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentObjs", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentObjs", "Name", c => c.Int(nullable: false));
        }
    }
}
