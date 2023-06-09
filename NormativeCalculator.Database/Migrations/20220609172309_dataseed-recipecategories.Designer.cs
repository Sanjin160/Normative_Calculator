﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NormativeCalculator.Database.EF;

namespace NormativeCalculator.Database.Migrations
{
    [DbContext(typeof(NormativeCalculatorDbContext))]
    [Migration("20220609172309_dataseed-recipecategories")]
    partial class dataseedrecipecategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("measureType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Suger",
                            Price = 2m,
                            Quantity = 100,
                            measureType = 3
                        },
                        new
                        {
                            Id = 2,
                            Name = "Flour",
                            Price = 6m,
                            Quantity = 100,
                            measureType = 5
                        },
                        new
                        {
                            Id = 3,
                            Name = "egg",
                            Price = 2m,
                            Quantity = 2,
                            measureType = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Brown suger",
                            Price = 2m,
                            Quantity = 200,
                            measureType = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = "Milk",
                            Price = 1m,
                            Quantity = 200,
                            measureType = 5
                        },
                        new
                        {
                            Id = 6,
                            Name = "Water",
                            Price = 2m,
                            Quantity = 1,
                            measureType = 5
                        },
                        new
                        {
                            Id = 7,
                            Name = "Buter",
                            Price = 4m,
                            Quantity = 350,
                            measureType = 3
                        },
                        new
                        {
                            Id = 8,
                            Name = "Walnut",
                            Price = 10m,
                            Quantity = 2,
                            measureType = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "Banana",
                            Price = 3m,
                            Quantity = 5,
                            measureType = 1
                        },
                        new
                        {
                            Id = 10,
                            Name = "Salt",
                            Price = 1m,
                            Quantity = 1,
                            measureType = 3
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecipeCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipeCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.RecipeCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RecipeCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2022, 6, 9, 19, 23, 9, 112, DateTimeKind.Local).AddTicks(3968),
                            Name = "Pancakes"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022),
                            Name = "Waffles"
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.RecipeIngredients", b =>
                {
                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("measureType")
                        .HasColumnType("int");

                    b.HasKey("IngredientId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Sanjin",
                            LastName = "Sabanovic",
                            PasswordHash = new byte[] { 109, 142, 112, 250, 177, 92, 202, 233, 252, 92, 120, 11, 200, 206, 0, 41, 68, 250, 212, 36, 195, 71, 88, 40, 15, 194, 83, 195, 138, 161, 205, 2, 243, 200, 60, 172, 246, 36, 119, 76, 115, 209, 99, 226, 228, 191, 139, 20, 9, 199, 52, 20, 6, 197, 112, 240, 179, 145, 125, 215, 203, 65, 149, 232 },
                            PasswordSalt = new byte[] { 111, 35, 41, 191, 109, 181, 162, 82, 59, 105, 205, 5, 76, 174, 126, 166, 44, 133, 32, 236, 47, 24, 202, 161, 25, 92, 132, 116, 144, 33, 32, 212, 45, 74, 157, 115, 204, 113, 193, 61, 236, 41, 20, 21, 218, 2, 195, 111, 157, 84, 252, 40, 119, 13, 38, 25, 46, 185, 8, 79, 13, 122, 119, 148, 232, 146, 92, 128, 1, 133, 28, 89, 110, 55, 69, 230, 177, 95, 92, 29, 227, 43, 124, 92, 16, 120, 50, 169, 181, 84, 24, 89, 73, 79, 114, 50, 48, 173, 158, 2, 210, 150, 99, 30, 49, 246, 138, 148, 20, 17, 178, 104, 245, 161, 84, 184, 26, 51, 17, 90, 72, 205, 111, 114, 81, 245, 124, 174 },
                            Username = "Sanjin"
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Recipe", b =>
                {
                    b.HasOne("NormativeCalculator.Database.Entities.RecipeCategories", "RecipeCategory")
                        .WithMany()
                        .HasForeignKey("RecipeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NormativeCalculator.Database.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RecipeCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.RecipeIngredients", b =>
                {
                    b.HasOne("NormativeCalculator.Database.Entities.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NormativeCalculator.Database.Entities.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Recipe", b =>
                {
                    b.Navigation("RecipeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
