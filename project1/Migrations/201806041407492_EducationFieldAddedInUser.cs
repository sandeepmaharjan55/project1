namespace project1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EducationFieldAddedInUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Education", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Education");
        }
    }
}
