namespace ERManyToOneDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentMarks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "StudentMarks", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "StudentMarks");
        }
    }
}
