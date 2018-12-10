﻿using System;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Parsing.Structure.NodeTypeProviders;
using Westeros.Diet.Data.Model;

namespace Westeros.Diet.Data.Repositories
{
    public class DietDbContext : DbContext
    {
        public DietDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DietDatabase;Integrated Security=True;");
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<RecipeDevice> RecipeDevices { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DietPlan> DietPlans { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<IngredientEntry> EntryIngredients { get; set; }
        public DbSet<RecipeEntry> EntryRecipes { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>().HasKey(p => new {p.IngredientId, p.RecipeId});

            var dev1 = new Device { Id = 1, Name = "Mikrofalówka" };
            var dev2 = new Device { Id = 2, Name = "Talerz" };
            var dev3 = new Device { Id = 3, Name = "Widelec" };
            var dev4 = new Device { Id = 4, Name = "Garnek" };
            var dev5 = new Device { Id = 5, Name = "Patelnia" };
            var dev6 = new Device { Id = 6, Name = "Wok" };

            modelBuilder.Entity<Device>().HasData(dev1, dev2, dev3, dev4, dev5, dev6);

            var ing1 = new Ingredient { Id = 1, Name = "Wołowina", Category = CategoryType.Meat, Calories = 250, Fats = 15.0, Carbohydrates = 0.0, Proteins = 26.0, AveragePrice = 3.5 };
            var ing2 = new Ingredient { Id = 2, Name = "Ser", Category = CategoryType.Dairy, Calories = 402, Fats = 33.0, Carbohydrates = 1.3, Proteins = 25.0, AveragePrice = 1.0 };
            var ing3 = new Ingredient { Id = 3, Name = "Drób", Category = CategoryType.Meat, Calories = 272, Fats = 25.0, Carbohydrates = 0.0, Proteins = 11.0, AveragePrice = 1.5 };
            var ing4 = new Ingredient { Id = 4, Name = "Łosoś", Category = CategoryType.Fish, Calories = 208, Fats = 12.0, Carbohydrates = 0.0, Proteins = 20.0, AveragePrice = 4.0 };
            var ing5 = new Ingredient { Id = 5, Name = "Winogrona", Category = CategoryType.Fruit, Calories = 66, Fats = 0.4, Carbohydrates = 17.0, Proteins = 0.6, AveragePrice = 0.8 };

            modelBuilder.Entity<Ingredient>().HasData(ing1, ing2, ing3, ing4, ing5);

        }
    }
}
