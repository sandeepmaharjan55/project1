namespace project1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignaFieldAddedInUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Designation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Designation");
        }
    }
}
