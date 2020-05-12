namespace ERManyToOneDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveStudentLocation : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Student", "StudentLocation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "StudentLocation", c => c.String());
        }
    }
}
