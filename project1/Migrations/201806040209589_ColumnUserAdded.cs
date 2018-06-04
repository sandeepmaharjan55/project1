namespace project1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnUserAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Email", c => c.String());
            AddColumn("dbo.Users", "Gender", c => c.String());
            AddColumn("dbo.Users", "Contact", c => c.String());
            AddColumn("dbo.Users", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Name");
            DropColumn("dbo.Users", "Contact");
            DropColumn("dbo.Users", "Gender");
            DropColumn("dbo.Users", "Email");
        }
    }
}
