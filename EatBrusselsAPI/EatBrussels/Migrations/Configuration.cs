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
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 2,
                        Name = "Da Claudio",
                        Address = "Chaussée de Waterloo 436, 1050 Ixelles",
                        ZipCode = "1050",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 3,
                        Name = "Saveurs d'Asie",
                        Address = "Avenue De Fré 195, 1180 Uccle",
                        ZipCode = "1180",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 4,
                        Name = "Lou",
                        Address = "Rue du Page 7, 1050 Ixelles",
                        ZipCode = "1050",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 5,
                        Name = "Chyl",
                        Address = "Rue de Belle-vue 62, 1000 Bruxelles",
                        ZipCode = "1000",
                        OpeningHour = "09:00",
                        ClosingHour = "20:00"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 6,
                        Name = "Dame Jeanne",
                        Address = "Boulevard d'Ypres 33, 1000 Bruxelles",
                        ZipCode = "1000",
                        OpeningHour = "11:00",
                        ClosingHour = "23:00"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 7,
                        Name = "Green Mango",
                        Address = "Chaussée de Vleurgat 142, 1050 Bruxelles",
                        ZipCode = "1050",
                        OpeningHour = "12:00",
                        ClosingHour = "23:00"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 8,
                        Name = "Menma",
                        Address = "Avenue des Saisons 123, 1050 Ixelles",
                        ZipCode = "1050",
                        OpeningHour = "12:00",
                        ClosingHour = "22:30"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 9,
                        Name = "La Cité Du Dragon",
                        Address = "Chaussée de Waterloo 1022-1024, 1180 Bruxelles",
                        ZipCode = "1080",
                        OpeningHour = "12:00",
                        ClosingHour = "22:00"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 10,
                        Name = "Le Schievelavabo",
                        Address = "Chaussée de Waterloo 1022-1024, 1180 Bruxelles",
                        ZipCode = "1080",
                        OpeningHour = "11:00",
                        ClosingHour = "23:00"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 11,
                        Name = "Le choux de Bruxelles",
                        Address = "Rue de Florence 26",
                        ZipCode = "1050",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 12,
                        Name = "La Manufacture",
                        Address = "Rue Notre-Dame-du-Sommeil 12",
                        ZipCode = "1000",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 13,
                        Name = "Le Rabassier",
                        Address = "Rue de Rollebeek 23",
                        ZipCode = "1000",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 14,
                        Name = "Toukoul",
                        Address = "Rue de Laeken 34",
                        ZipCode = "1000",
                        OpeningHour = "18:00",
                        ClosingHour = "22:30"
                    },
                    new Restaurant()
                    {
                        RestaurantID = 15,
                        Name = "Publico",
                        Address = "Rue des Chartreux 32",
                        ZipCode = "1000",
                        OpeningHour = "11:00",
                        ClosingHour = "00:00"
                    }
                );

            context.Kitchens.AddOrUpdate(
                    new Kitchen() { KitchenTypeID = 1, RestaurantID = 1 },
                    new Kitchen() { KitchenTypeID = 1, RestaurantID = 2 },
                    new Kitchen() { KitchenTypeID = 2, RestaurantID = 3 },
                    new Kitchen() { KitchenTypeID = 3, RestaurantID = 4 },
                    new Kitchen() { KitchenTypeID = 4, RestaurantID = 5 },
                    new Kitchen() { KitchenTypeID = 5, RestaurantID = 6 },
                    new Kitchen() { KitchenTypeID = 6, RestaurantID = 7 },
                    new Kitchen() { KitchenTypeID = 7, RestaurantID = 8 },
                    new Kitchen() { KitchenTypeID = 8, RestaurantID = 9 },
                    new Kitchen() { KitchenTypeID = 9, RestaurantID = 10 },
                    new Kitchen() { KitchenTypeID = 10, RestaurantID = 11 },
                    new Kitchen() { KitchenTypeID = 1, RestaurantID = 12 },
                    new Kitchen() { KitchenTypeID = 5, RestaurantID = 13 },
                    new Kitchen() { KitchenTypeID = 2, RestaurantID = 14 },
                    new Kitchen() { KitchenTypeID = 3, RestaurantID = 15 });

            context.Images.AddOrUpdate(
                new Image() { RestaurantID = 1, ImageUrl = "https://cdn.filestackcontent.com/FIIBSMXReqsJd20Cr1kL" },
                new Image() { RestaurantID = 11, ImageUrl = "https://cdn.filestackcontent.com/X43bXCD8S068TY6t3XRk" },
                new Image() { RestaurantID = 5, ImageUrl = "https://cdn.filestackcontent.com/uqv6XMQmTa2col9Z80Bc" },
                new Image() { RestaurantID = 9, ImageUrl = "https://cdn.filestackcontent.com/6uE3c2OJQg0Kz0HKoCSg" },
                new Image() { RestaurantID = 2, ImageUrl = "https://cdn.filestackcontent.com/gwKKzUQkW3x3weVHvJwq" },
                new Image() { RestaurantID = 7, ImageUrl = "https://cdn.filestackcontent.com/P84DMK2SgGtzXQ6j2rdu" },
                new Image() { RestaurantID = 6, ImageUrl = "https://cdn.filestackcontent.com/1okROa03SIm0UU5v5kZP" },
                new Image() { RestaurantID = 4, ImageUrl = "https://cdn.filestackcontent.com/OHpNAkW2RKqX88PDFoJL" },
                new Image() { RestaurantID = 12, ImageUrl = "https://cdn.filestackcontent.com/FdrpsNuPScqxZ9gM8OLn" },
                new Image() { RestaurantID = 8, ImageUrl = "https://cdn.filestackcontent.com/b5grQsUTtqm4abFxmZwK" },
                new Image() { RestaurantID = 15, ImageUrl = "https://cdn.filestackcontent.com/lQqxI6yNTDWGvjgEhenq" },
                new Image() { RestaurantID = 13, ImageUrl = "https://cdn.filestackcontent.com/udnDGdCQROamLlQwbNVj" },
                new Image() { RestaurantID = 3, ImageUrl = "https://cdn.filestackcontent.com/dt088a6hS2i1XGtCUjUp" },
                new Image() { RestaurantID = 10, ImageUrl = "https://cdn.filestackcontent.com/VtJfU8tjTlyDI4D8xvtR" },
                new Image() { RestaurantID = 14, ImageUrl = "https://cdn.filestackcontent.com/rHueqHnpQ8ygJ64HgV70" });



            context.SaveChanges();
        }
    }
}
