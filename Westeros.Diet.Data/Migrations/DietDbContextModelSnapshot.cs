﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Westeros.Diet.Data.Repositories;

namespace Westeros.Diet.Data.Migrations
{
    [DbContext(typeof(DietDbContext))]
    partial class DietDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Westeros.Diet.Data.Model.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.DietPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calories");

                    b.Property<decimal>("Carbohydrates");

                    b.Property<decimal>("Fats");

                    b.Property<string>("Name");

                    b.Property<decimal>("Proteins");

                    b.Property<int?>("UserProfileId");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId");

                    b.ToTable("DietPlans");
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AveragePrice");

                    b.Property<int>("Calories");

                    b.Property<double>("Carbohydrates");

                    b.Property<int>("Category");

                    b.Property<double>("Fats");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<double>("Proteins");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.IngredientEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntryId");

                    b.Property<int>("IngredientId");

                    b.HasKey("Id");

                    b.HasIndex("EntryId");

                    b.HasIndex("IngredientId");

                    b.ToTable("EntryIngredients");
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calories");

                    b.Property<double>("Carbohydrates");

                    b.Property<int>("Cuisine");

                    b.Property<string>("Description");

                    b.Property<int>("Difficulty");

                    b.Property<double>("Fats");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<int>("PrepTime");

                    b.Property<string>("PriceBar");

                    b.Property<double>("Proteins");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.RecipeDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeviceId");

                    b.Property<int>("RecipeId");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeDevices");
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.RecipeEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntryId");

                    b.Property<int>("RecipeId");

                    b.HasKey("Id");

                    b.HasIndex("EntryId");

                    b.HasIndex("RecipeId");

                    b.ToTable("EntryRecipes");
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.RecipeIngridient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IngredientId");

                    b.Property<int>("RecipeId");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngridients");
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Email");

                    b.Property<int>("Gender");

                    b.Property<double>("Height");

                    b.Property<string>("Login");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.DietPlan", b =>
                {
                    b.HasOne("Westeros.Diet.Data.Model.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId");
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.IngredientEntry", b =>
                {
                    b.HasOne("Westeros.Diet.Data.Model.Entry", "Entry")
                        .WithMany("EntryIngredients")
                        .HasForeignKey("EntryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Westeros.Diet.Data.Model.Ingredient", "Ingredient")
                        .WithMany("IngredientEntries")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.RecipeDevice", b =>
                {
                    b.HasOne("Westeros.Diet.Data.Model.Device", "Device")
                        .WithMany("RecipeDevices")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Westeros.Diet.Data.Model.Recipe", "Recipe")
                        .WithMany("RecipeDevices")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.RecipeEntry", b =>
                {
                    b.HasOne("Westeros.Diet.Data.Model.Entry", "Entry")
                        .WithMany("EntryRecipes")
                        .HasForeignKey("EntryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Westeros.Diet.Data.Model.Recipe", "Recipe")
                        .WithMany("EntryRecipes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Westeros.Diet.Data.Model.RecipeIngridient", b =>
                {
                    b.HasOne("Westeros.Diet.Data.Model.Ingredient", "Ingredient")
                        .WithMany("IngredientRecipes")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Westeros.Diet.Data.Model.Recipe", "Recipe")
                        .WithMany("IngredientRecipes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
