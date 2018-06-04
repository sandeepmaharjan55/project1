namespace project1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompaniesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Phoneno = c.Int(nullable: false),
                        ContactPerson = c.String(),
                        CompanyURL = c.String(),
                        Logo = c.String(),
                        FacebookURL = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Companies");
        }
    }
}
