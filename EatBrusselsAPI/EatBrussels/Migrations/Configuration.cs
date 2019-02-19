namespace EatBrussels.Migrations
{
    using EatBrussels.Entities;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EatBrussels.Entities.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "EatBrussels.Models.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //context.Roles.AddOrUpdate(new IdentityRole("Administrator"));
            //context.Roles.AddOrUpdate(new IdentityRole("Restaurateur"));
            //context.Roles.AddOrUpdate(new IdentityRole("Client"));

            context.Users.AddOrUpdate(new ApplicationUser()
            {
                Id = "1",
                Email = "punkimati@hotmail.com",
                UserName = "admin",
                PhoneNumber = "049634587",
                PasswordHash = "AOkNhc5xSg2tHwXxAxzkBvODo035PdSIBJ8hqit5fQIcMbNN + zydwC0wuxdcRwPP / w =="
            });

            context.SaveChanges();
        }
    }
}
