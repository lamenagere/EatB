namespace EatBrussels.Migrations
{
    using EatBrussels.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EatBrussels.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EatBrussels.Models.ApplicationDbContext";
        }

        protected override void Seed(EatBrussels.Models.ApplicationDbContext context)
        {
            context.Roles.Add(new IdentityRole("Administrator"));
            context.Roles.Add(new IdentityRole("Restaurateur"));
            context.Roles.Add(new IdentityRole("Client"));

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
