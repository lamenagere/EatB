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
                    new KitchenType() {  KitchenTypeID=1, KitchenLabel="Belge" },
                    new KitchenType() { KitchenTypeID = 2, KitchenLabel = "Asiatique" },
                    new KitchenType() { KitchenTypeID = 3, KitchenLabel = "Italienne" },
                    new KitchenType() { KitchenTypeID = 4, KitchenLabel = "Burger" },
                    new KitchenType() { KitchenTypeID = 5, KitchenLabel = "Nouilles" },
                    new KitchenType() { KitchenTypeID = 6, KitchenLabel = "Française" },
                    new KitchenType() { KitchenTypeID = 7, KitchenLabel = "Ethiopienne" });


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
                        Name = "le Balmoral",
                        Address = "Place Georges Brugmann 21, 1180 Uccle",
                        ZipCode = "1180",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        Name = "Da Claudio",
                        Address = "Chaussée de Waterloo 436, 1050 Ixelles",
                        ZipCode = "1050",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        Name = "Saveurs d'Asie",
                        Address = "Avenue De Fré 195, 1180 Uccle",
                        ZipCode = "1180",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        Name = "Lou",
                        Address = "Rue du Page 7, 1050 Ixelles",
                        ZipCode = "1050",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        Name = "Chyl",
                        Address = "Rue de Belle-vue 62, 1000 Bruxelles",
                        ZipCode = "1000",
                        OpeningHour = "09:00",
                        ClosingHour = "20:00"
                    },
                    new Restaurant()
                    {
                        Name = "Dame Jeanne",
                        Address = "Boulevard d'Ypres 33, 1000 Bruxelles",
                        ZipCode = "1000",
                        OpeningHour = "11:00",
                        ClosingHour = "23:00"
                    },
                    new Restaurant()
                    {
                        Name = "Green Mango",
                        Address = "Chaussée de Vleurgat 142, 1050 Bruxelles",
                        ZipCode = "1050",
                        OpeningHour = "12:00",
                        ClosingHour = "23:00"
                    },
                    new Restaurant()
                    {
                        Name = "Menma",
                        Address = "Avenue des Saisons 123, 1050 Ixelles",
                        ZipCode = "1050",
                        OpeningHour = "12:00",
                        ClosingHour = "22:30"
                    },
                    new Restaurant()
                    {
                        Name = "La Cité Du Dragon",
                        Address = "Chaussée de Waterloo 1022-1024, 1180 Bruxelles",
                        ZipCode = "1080",
                        OpeningHour = "12:00",
                        ClosingHour = "22:00"
                    },
                    new Restaurant()
                    {
                        Name = "Le Schievelavabo",
                        Address = "Chaussée de Waterloo 1022-1024, 1180 Bruxelles",
                        ZipCode = "1080",
                        OpeningHour = "11:00",
                        ClosingHour = "23:00"
                    },
                    new Restaurant()
                    {
                        Name = "Le choux de Bruxelles",
                        Address = "Rue de Florence 26",
                        ZipCode = "1050",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        Name = "La Manufacture",
                        Address = "Rue Notre-Dame-du-Sommeil 12",
                        ZipCode = "1000",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        Name = "Le Rabassier",
                        Address = "Rue de Rollebeek 23",
                        ZipCode = "1000",
                        OpeningHour = "10:00",
                        ClosingHour = "19:00"
                    },
                    new Restaurant()
                    {
                        Name = "Toukoul",
                        Address = "Rue de Laeken 34",
                        ZipCode = "1000",
                        OpeningHour = "18:00",
                        ClosingHour = "22:30"
                    },
                    new Restaurant()
                    {
                        Name = "Publico",
                        Address = "Rue des Chartreux 32",
                        ZipCode = "1000",
                        OpeningHour = "11:00",
                        ClosingHour = "00:00"
                    }
                );


            context.SaveChanges();
        }
    }
}
