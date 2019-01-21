﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Westeros.UserProfile.Data;
using Westeros.UserProfile.Data.Repositories;

namespace Westeros.UserProfile.Data.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20190119185707_CreateUserDB5")]
    partial class CreateUserDB5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Westeros.UserProfile.Data.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("age");

                    b.Property<string>("email");

                    b.Property<int>("gender");

                    b.Property<string>("login");

                    b.Property<string>("name");

                    b.Property<string>("surname");

                    b.Property<int>("weight");

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Westeros.UserProfile.Data.UserRecipe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RecipeID");

                    b.Property<int>("UserID");

                    b.HasKey("id");

                    b.HasIndex("UserID");

                    b.ToTable("UserRecipe");
                });

            modelBuilder.Entity("Westeros.UserProfile.Data.UserRecipe", b =>
                {
                    b.HasOne("Westeros.UserProfile.Data.User")
                        .WithMany("favouriteRecipes")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}