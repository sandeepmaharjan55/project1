namespace project1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SkillAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillId = c.Int(nullable: false, identity: true),
                        Skills = c.String(),
                    })
                .PrimaryKey(t => t.SkillId);
            
            CreateTable(
                "dbo.UserToSkills",
                c => new
                    {
                        UserToSkillId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        SkillId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserToSkillId)
                .ForeignKey("dbo.Skills", t => t.SkillId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.SkillId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserToSkills", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserToSkills", "SkillId", "dbo.Skills");
            DropIndex("dbo.UserToSkills", new[] { "SkillId" });
            DropIndex("dbo.UserToSkills", new[] { "UserId" });
            DropTable("dbo.UserToSkills");
            DropTable("dbo.Skills");
        }
    }
}
