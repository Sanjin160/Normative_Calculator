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
    [Migration("20220610085235_dataseed-userr")]
    partial class dataseeduserr
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
                            DateCreated = new DateTime(2022, 6, 10, 10, 52, 34, 487, DateTimeKind.Local).AddTicks(9243),
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
                            PasswordHash = new byte[] { 35, 83, 8, 237, 156, 72, 123, 24, 62, 128, 230, 97, 134, 232, 32, 8, 31, 237, 33, 105, 201, 249, 200, 173, 3, 110, 192, 55, 39, 106, 189, 145, 161, 206, 123, 132, 197, 102, 178, 164, 12, 4, 191, 141, 15, 40, 82, 7, 44, 225, 198, 255, 250, 161, 21, 71, 165, 226, 203, 223, 79, 16, 75, 172 },
                            PasswordSalt = new byte[] { 21, 30, 33, 175, 232, 43, 142, 162, 194, 227, 133, 225, 180, 199, 251, 126, 241, 69, 169, 185, 211, 83, 80, 116, 150, 98, 126, 192, 148, 184, 61, 27, 255, 150, 194, 23, 151, 103, 125, 54, 190, 123, 151, 164, 138, 62, 163, 209, 94, 45, 236, 166, 42, 72, 135, 234, 253, 7, 137, 154, 157, 118, 218, 54, 92, 74, 97, 128, 233, 233, 120, 80, 28, 43, 189, 240, 60, 54, 27, 14, 187, 193, 196, 255, 206, 133, 190, 188, 177, 3, 156, 225, 123, 74, 227, 10, 154, 87, 234, 96, 31, 229, 182, 207, 152, 96, 208, 78, 221, 184, 230, 177, 74, 244, 124, 92, 253, 114, 40, 254, 225, 190, 116, 191, 20, 69, 71, 132 },
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