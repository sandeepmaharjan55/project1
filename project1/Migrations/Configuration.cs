namespace project1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<project1.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(project1.Models.MyDbContext context)
        {
            context.Roles.AddOrUpdate(new Models.Role()
            {
                Id=1,
                Name="Admin"
            }
                );
            context.Roles.AddOrUpdate(new Models.Role()
            {
                Id = 2,
                Name = "Manager"
            }
               );
            context.Roles.AddOrUpdate(new Models.Role()
            {
                Id = 3,
                Name = "User"
            }
               );
            context.Roles.AddOrUpdate(new Models.Role()
            {
                Id = 4,
                Name = "Sales"
            }
               );
            context.Users.AddOrUpdate(new Models.User()
            {
                Id = 1,Username="admin",Password="admin",
                AddedDate=DateTime.Now,Status=true
            }
               );
            context.UserRoles.AddOrUpdate(new Models.UserRole()
            {
                Id = 1,
                RoleId=1,UserId=1
            }
               );
        }
    }
}
