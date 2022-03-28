﻿// <auto-generated />
using System;
using CookBook.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CookBook.DAL.Migrations
{
    [DbContext(typeof(CookBookDbContext))]
    [Migration("20220101130416_Refactor records")]
    partial class Refactorrecords
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CookBook.DAL.Entities.IngredientAmountEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("IngredientAmountEntities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0d4fa150-ad80-4d46-a511-4c666166ec5e"),
                            Amount = 1.0,
                            IngredientId = new Guid("df935095-8709-4040-a2bb-b6f97cb416dc"),
                            RecipeId = new Guid("fabde0cd-eefe-443f-baf6-3d96cc2cbf2e"),
                            Unit = 1
                        },
                        new
                        {
                            Id = new Guid("87833e66-05ba-4d6b-900b-fe5ace88dbd8"),
                            Amount = 2.0,
                            IngredientId = new Guid("23b3902d-7d4f-4213-9cf0-112348f56238"),
                            RecipeId = new Guid("fabde0cd-eefe-443f-baf6-3d96cc2cbf2e"),
                            Unit = 2
                        });
                });

            modelBuilder.Entity("CookBook.DAL.Entities.IngredientEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("df935095-8709-4040-a2bb-b6f97cb416dc"),
                            Description = "Ingredient seeded ingredient 1 description",
                            Name = "Ingredient seeded ingredient 1"
                        },
                        new
                        {
                            Id = new Guid("23b3902d-7d4f-4213-9cf0-112348f56238"),
                            Description = "Ingredient seeded ingredient 2 description",
                            Name = "Ingredient seeded ingredient 2"
                        },
                        new
                        {
                            Id = new Guid("06a8a2cf-ea03-4095-a3e4-aa0291fe9c75"),
                            Description = "Mineral water",
                            ImageUrl = "https://www.pngitem.com/pimgs/m/40-406527_cartoon-glass-of-water-png-glass-of-water.png",
                            Name = "Water"
                        });
                });

            modelBuilder.Entity("CookBook.DAL.Entities.RecipeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<int>("FoodType")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fabde0cd-eefe-443f-baf6-3d96cc2cbf2e"),
                            Description = "Recipe seeded recipe 1 description",
                            Duration = new TimeSpan(0, 2, 0, 0, 0),
                            FoodType = 1,
                            Name = "Recipe seeded recipe 1"
                        });
                });

            modelBuilder.Entity("CookBook.DAL.Entities.IngredientAmountEntity", b =>
                {
                    b.HasOne("CookBook.DAL.Entities.IngredientEntity", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CookBook.DAL.Entities.RecipeEntity", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("CookBook.DAL.Entities.RecipeEntity", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
