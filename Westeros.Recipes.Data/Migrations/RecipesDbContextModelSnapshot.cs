﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Westeros.Recipes.Data.Repositories;

namespace Westeros.Recipes.Data.Migrations
{
    [DbContext(typeof(RecipesDbContext))]
    partial class RecipesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Westeros.Recipes.Data.Ingridient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AvgPrice");

                    b.Property<double>("Calories");

                    b.Property<double>("Carbohydrates");

                    b.Property<int>("Category");

                    b.Property<double>("Fats");

                    b.Property<string>("Name");

                    b.Property<string>("PhotoPath");

                    b.Property<double>("Proteins");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Westeros.Recipes.Data.Model.Device", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Westeros.Recipes.Data.Model.RecipeDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeviceId");

                    b.Property<int>("RecipeId");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeDevice");
                });

            modelBuilder.Entity("Westeros.Recipes.Data.Model.RecipeIngridient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IngridientId");

                    b.Property<int>("RecipeId");

                    b.HasKey("Id");

                    b.HasIndex("IngridientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");
                });

            modelBuilder.Entity("Westeros.Recipes.Data.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Calories");

                    b.Property<double>("Carbohydrates");

                    b.Property<int>("Cuisine");

                    b.Property<string>("Description");

                    b.Property<int>("Difficulty");

                    b.Property<double>("Fats");

                    b.Property<string>("Name");

                    b.Property<string>("PhotoPath");

                    b.Property<int>("PrepTime");

                    b.Property<string>("PriceBar");

                    b.Property<double>("Proteins");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Westeros.Recipes.Data.Model.RecipeDevice", b =>
                {
                    b.HasOne("Westeros.Recipes.Data.Model.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Westeros.Recipes.Data.Recipe", "Recipe")
                        .WithMany("RecipeDevices")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Westeros.Recipes.Data.Model.RecipeIngridient", b =>
                {
                    b.HasOne("Westeros.Recipes.Data.Ingridient", "Ingridient")
                        .WithMany("RecipeIngridients")
                        .HasForeignKey("IngridientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Westeros.Recipes.Data.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
