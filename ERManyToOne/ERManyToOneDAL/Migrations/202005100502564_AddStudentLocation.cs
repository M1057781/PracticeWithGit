namespace ERManyToOneDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "StudentLocation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "StudentLocation");
        }
    }
}
