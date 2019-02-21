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
            

            context.Database.ExecuteSqlCommand("ALTER TABLE [KitchenTypes] NOCHECK CONSTRAINT ALL");
            context.Database.ExecuteSqlCommand("DELETE FROM [KitchenTypes]");

            context.Database.ExecuteSqlCommand("ALTER TABLE [Restaurants] NOCHECK CONSTRAINT ALL");
            context.Database.ExecuteSqlCommand("DELETE FROM [Restaurants]");

            context.Database.ExecuteSqlCommand("ALTER TABLE [Images] NOCHECK CONSTRAINT ALL");
            context.Database.ExecuteSqlCommand("DELETE FROM [Images]");

            context.Database.ExecuteSqlCommand("ALTER TABLE [Comments] NOCHECK CONSTRAINT ALL");
            context.Database.ExecuteSqlCommand("DELETE FROM [Comments]");

            context.Database.ExecuteSqlCommand("ALTER TABLE [Kitchens] NOCHECK CONSTRAINT ALL");
            context.Database.ExecuteSqlCommand("DELETE FROM [Kitchens]");

            context.Database.ExecuteSqlCommand("ALTER TABLE [Ratings] NOCHECK CONSTRAINT ALL");
            context.Database.ExecuteSqlCommand("DELETE FROM [Ratings]");

            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Comments', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Images', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Kitchens', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('KitchenTypes', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Ratings', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Restaurants', RESEED, 0)");

            context.Database.ExecuteSqlCommand("ALTER TABLE [KitchenTypes] CHECK CONSTRAINT ALL");
            context.Database.ExecuteSqlCommand("ALTER TABLE [Restaurants] CHECK CONSTRAINT ALL");
            context.Database.ExecuteSqlCommand("ALTER TABLE [Images] CHECK CONSTRAINT ALL");
            context.Database.ExecuteSqlCommand("ALTER TABLE [Comments] CHECK CONSTRAINT ALL");
            context.Database.ExecuteSqlCommand("ALTER TABLE [Kitchens] CHECK CONSTRAINT ALL");
            context.Database.ExecuteSqlCommand("ALTER TABLE [Ratings] CHECK CONSTRAINT ALL");

            context.Roles.AddOrUpdate(new IdentityRole { Name = "Administrator" });
            context.Roles.AddOrUpdate(new IdentityRole { Name = "Restaurateur" });                     
            context.Roles.AddOrUpdate(new IdentityRole { Name = "Client" });    



            context.KitchenTypes.AddOrUpdate(
                    new KitchenType() { KitchenTypeID = 1, KitchenLabel="Belge" },
                    new KitchenType() { KitchenTypeID = 2, KitchenLabel = "Asiatique" },
                    new KitchenType() { KitchenTypeID = 3, KitchenLabel = "Italienne" },
                    new KitchenType() { KitchenTypeID = 4, KitchenLabel = "Burger" },
                    new KitchenType() { KitchenTypeID = 5, KitchenLabel = "Nouilles" },
                    new KitchenType() { KitchenTypeID = 6, KitchenLabel = "Française" },
                    new KitchenType() { KitchenTypeID = 7, KitchenLabel = "Ethiopienne" },
                    new KitchenType() { KitchenTypeID = 8, KitchenLabel = "Américaine" },
                    new KitchenType() { KitchenTypeID = 9, KitchenLabel = "Européenne" },
                    new KitchenType() { KitchenTypeID = 10, KitchenLabel = "Healthy" });


            context.Users.AddOrUpdate(new ApplicationUser()
            {
                Id = "1",
                Email = "punkimati@hotmail.com",
                UserName = "admin",
                PhoneNumber = "049634587",
                PasswordHash = "AOkNhc5xSg2tHwXxAxzkBvODo035PdSIBJ8hqit5fQIcMbNN + zydwC0wuxdcRwPP / w =="
            });

            context.Restaurants.AddOrUpdate(
                    new Restaurant()
                    {
                        RestaurantID = 1,
                        Name = "le Balmoral",
                        Address = "Place Georges Brugmann 21, 1180 Uccle",
                        ZipCode = "1180",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 2,
                        Name = "Da Claudio",
                        Address = "Chaussée de Waterloo 436, 1050 Ixelles",
                        ZipCode = "1050",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 3,
                        Name = "Saveurs d'Asie",
                        Address = "Avenue De Fré 195, 1180 Uccle",
                        ZipCode = "1180",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 4,
                        Name = "Lou",
                        Address = "Rue du Page 7, 1050 Ixelles",
                        ZipCode = "1050",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 5,
                        Name = "Chyl",
                        Address = "Rue de Belle-vue 62, 1000 Bruxelles",
                        ZipCode = "1000",
                        OpeningHour = "09:00",
                        ClosingHour = "20:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 6,
                        Name = "Dame Jeanne",
                        Address = "Boulevard d'Ypres 33, 1000 Bruxelles",
                        ZipCode = "1000",
                        OpeningHour = "11:00",
                        ClosingHour = "23:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 7,
                        Name = "Green Mango",
                        Address = "Chaussée de Vleurgat 142, 1050 Bruxelles",
                        ZipCode = "1050",
                        OpeningHour = "12:00",
                        ClosingHour = "23:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 8,
                        Name = "Menma",
                        Address = "Avenue des Saisons 123, 1050 Ixelles",
                        ZipCode = "1050",
                        OpeningHour = "12:00",
                        ClosingHour = "22:30",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 9,
                        Name = "La Cité Du Dragon",
                        Address = "Chaussée de Waterloo 1022-1024, 1180 Bruxelles",
                        ZipCode = "1080",
                        OpeningHour = "12:00",
                        ClosingHour = "22:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 10,
                        Name = "Le Schievelavabo",
                        Address = "Chaussée de Waterloo 1022-1024, 1180 Bruxelles",
                        ZipCode = "1080",
                        OpeningHour = "11:00",
                        ClosingHour = "23:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 11,
                        Name = "Le choux de Bruxelles",
                        Address = "Rue de Florence 26",
                        ZipCode = "1050",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 12,
                        Name = "La Manufacture",
                        Address = "Rue Notre-Dame-du-Sommeil 12",
                        ZipCode = "1000",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 13,
                        Name = "Le Rabassier",
                        Address = "Rue de Rollebeek 23",
                        ZipCode = "1000",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 14,
                        Name = "Toukoul",
                        Address = "Rue de Laeken 34",
                        ZipCode = "1000",
                        OpeningHour = "18:00",
                        ClosingHour = "22:30",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 15,
                        Name = "Publico",
                        Address = "Rue des Chartreux 32",
                        ZipCode = "1000",
                        OpeningHour = "11:00",
                        ClosingHour = "00:00",
                        Description = ""
                    },



                    new Restaurant()
                    {
                        RestaurantID = 16,
                        Name = "Les Super Filles du Tram",
                        Address = "Rue Lesbroussart 22, 1050 Ixelles",
                        ZipCode = "1050",
                        OpeningHour = "12:00",
                        ClosingHour = "22:30",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 17,
                        Name = "YAG",
                        Address = "Rue Washington 59, 1050 Ixelles",
                        ZipCode = "1050",
                        OpeningHour = "12:00",
                        ClosingHour = "20:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 18,
                        Name = "Le fils de Jules",
                        Address = "Rue du Page 22, 1050 Ixelles",
                        ZipCode = "1050",
                        OpeningHour = "18:30",
                        ClosingHour = "23:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 19,
                        Name = "La Table",
                        Address = "Rue d'Arlon 37, 1000 Bruxelles",
                        ZipCode = "1000",
                        OpeningHour = "12:30",
                        ClosingHour = "15:00",
                        Description = ""
                    },
                    new Restaurant()
                    {
                        RestaurantID = 20,
                        Name = "Chou",
                        Address = "Place de Londres 4, 1050 Ixelles",
                        ZipCode = "1050",
                        OpeningHour = "12:00",
                        ClosingHour = "15:00",
                        Description = ""
                    }
                );

            context.Kitchens.AddOrUpdate(
                    new Kitchen() { KitchenTypeID = 1, RestaurantID = 1 },
                    new Kitchen() { KitchenTypeID = 1, RestaurantID = 2 },
                    new Kitchen() { KitchenTypeID = 2, RestaurantID = 3 },
                    new Kitchen() { KitchenTypeID = 3, RestaurantID = 4 },
                    new Kitchen() { KitchenTypeID = 4, RestaurantID = 5 },
                    new Kitchen() { KitchenTypeID = 5, RestaurantID = 6 },
                    new Kitchen() { KitchenTypeID = 8, RestaurantID = 7 },
                    new Kitchen() { KitchenTypeID = 2, RestaurantID = 8 },
                    new Kitchen() { KitchenTypeID = 8, RestaurantID = 9 },
                    new Kitchen() { KitchenTypeID = 9, RestaurantID = 10 },
                    new Kitchen() { KitchenTypeID = 10, RestaurantID = 11 },
                    new Kitchen() { KitchenTypeID = 1, RestaurantID = 12 },
                    new Kitchen() { KitchenTypeID = 9, RestaurantID = 13 },
                    new Kitchen() { KitchenTypeID = 2, RestaurantID = 14 },
                    new Kitchen() { KitchenTypeID = 3, RestaurantID = 15 },
                    new Kitchen() { KitchenTypeID = 8, RestaurantID = 16 },
                    new Kitchen() { KitchenTypeID = 10, RestaurantID = 17 },
                    new Kitchen() { KitchenTypeID = 10, RestaurantID = 18 },
                    new Kitchen() { KitchenTypeID = 9, RestaurantID = 19 },
                    new Kitchen() { KitchenTypeID = 9, RestaurantID = 20 });

            context.Images.AddOrUpdate(
                new Image() { RestaurantID = 1, ImageUrl = "https://i.imgur.com/Q1VbydX.jpg" },
                new Image() { RestaurantID = 11, ImageUrl = "https://i.imgur.com/Hycue4X.jpg" },
                new Image() { RestaurantID = 5, ImageUrl = "https://i.imgur.com/efZ4WkA.jpg" },
                new Image() { RestaurantID = 9, ImageUrl = "https://i.imgur.com/LokPmMK.jpg" },
                new Image() { RestaurantID = 2, ImageUrl = "https://i.imgur.com/t9ZRRUo.jpg" },
                new Image() { RestaurantID = 7, ImageUrl = "https://i.imgur.com/VQ1NQly.jpg" },
                new Image() { RestaurantID = 6, ImageUrl = "https://i.imgur.com/NaIa44e.jpg" },
                new Image() { RestaurantID = 4, ImageUrl = "https://i.imgur.com/9RIf5HP.jpg" },
                new Image() { RestaurantID = 12, ImageUrl = "https://i.imgur.com/R717Ebj.jpg" },
                new Image() { RestaurantID = 8, ImageUrl = "https://i.imgur.com/IC817wu.jpg" },
                new Image() { RestaurantID = 15, ImageUrl = "https://i.imgur.com/EANw0tv.jpg" },
                new Image() { RestaurantID = 13, ImageUrl = "https://i.imgur.com/inyAhM8.jpg" },
                new Image() { RestaurantID = 3, ImageUrl = "https://i.imgur.com/G7NI1GC.jpg" },
                new Image() { RestaurantID = 10, ImageUrl = "https://i.imgur.com/V5yt6HT.jpg" },
                new Image() { RestaurantID = 14, ImageUrl = "https://i.imgur.com/fKYM9cz.jpg" });

            context.Ratings.AddOrUpdate(
                new Rating() { RestaurantID = 1, UserID = 1, Rate = 3 },
                new Rating() { RestaurantID = 1, UserID = 1, Rate = 1 },
                new Rating() { RestaurantID = 1, UserID = 1, Rate = 4 },
                new Rating() { RestaurantID = 1, UserID = 1, Rate = 5 }
                );

            context.SaveChanges();
        }
    }
}
