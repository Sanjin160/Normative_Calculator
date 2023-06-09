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
    [Migration("20220614080923_base-entity")]
    partial class baseentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2022, 6, 14, 10, 9, 22, 926, DateTimeKind.Local).AddTicks(7166),
                            Name = "Pancakes"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022),
                            Name = "Waffles"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022),
                            Name = "Cake"
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022),
                            Name = "Lava cake"
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022),
                            Name = "Muffin"
                        },
                        new
                        {
                            Id = 6,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2022),
                            Name = "Carrot cake"
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MeasureType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MeasureType = 3,
                            Name = "Suger",
                            Price = 2m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 2,
                            MeasureType = 5,
                            Name = "Flour",
                            Price = 6m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 3,
                            MeasureType = 1,
                            Name = "egg",
                            Price = 2m,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 4,
                            MeasureType = 3,
                            Name = "Brown suger",
                            Price = 2m,
                            Quantity = 200
                        },
                        new
                        {
                            Id = 5,
                            MeasureType = 5,
                            Name = "Milk",
                            Price = 1m,
                            Quantity = 200
                        },
                        new
                        {
                            Id = 6,
                            MeasureType = 5,
                            Name = "Water",
                            Price = 2m,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 7,
                            MeasureType = 3,
                            Name = "Buter",
                            Price = 4m,
                            Quantity = 350
                        },
                        new
                        {
                            Id = 8,
                            MeasureType = 2,
                            Name = "Walnut",
                            Price = 10m,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 9,
                            MeasureType = 1,
                            Name = "Banana",
                            Price = 3m,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 10,
                            MeasureType = 3,
                            Name = "Salt",
                            Price = 1m,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.RecipeIngredients", b =>
                {
                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("MeasureType")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
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
                            PasswordHash = new byte[] { 87, 239, 59, 170, 114, 250, 71, 48, 201, 9, 164, 120, 232, 95, 243, 8, 146, 38, 65, 80, 76, 92, 243, 162, 128, 129, 100, 207, 216, 82, 177, 80, 130, 37, 34, 23, 156, 119, 55, 108, 223, 234, 209, 234, 123, 44, 2, 141, 152, 181, 89, 75, 209, 39, 82, 220, 107, 141, 53, 57, 99, 201, 152, 97 },
                            PasswordSalt = new byte[] { 45, 193, 134, 107, 48, 22, 175, 216, 243, 129, 35, 214, 90, 27, 27, 14, 110, 101, 80, 255, 186, 63, 62, 14, 209, 139, 236, 117, 206, 242, 48, 238, 24, 63, 114, 245, 140, 130, 241, 82, 212, 28, 50, 65, 2, 7, 74, 167, 24, 24, 106, 29, 180, 4, 10, 173, 245, 5, 22, 171, 54, 0, 24, 38, 50, 158, 113, 188, 71, 108, 14, 185, 176, 122, 117, 208, 247, 244, 129, 9, 173, 218, 230, 199, 131, 99, 189, 174, 190, 26, 42, 117, 230, 164, 202, 58, 88, 218, 88, 46, 158, 137, 77, 113, 233, 33, 66, 223, 159, 26, 213, 42, 209, 130, 48, 137, 84, 29, 112, 214, 217, 37, 127, 181, 251, 212, 46, 83 },
                            Username = "sanjin"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Merisa",
                            LastName = "Mulac",
                            PasswordHash = new byte[] { 136, 55, 65, 123, 220, 35, 201, 144, 98, 166, 178, 92, 12, 114, 205, 163, 32, 3, 183, 105, 113, 34, 218, 9, 161, 233, 118, 193, 178, 41, 235, 218, 214, 192, 18, 102, 60, 203, 53, 129, 98, 173, 111, 146, 7, 155, 54, 60, 7, 204, 140, 169, 251, 208, 19, 250, 103, 57, 4, 119, 218, 146, 134, 60 },
                            PasswordSalt = new byte[] { 45, 193, 134, 107, 48, 22, 175, 216, 243, 129, 35, 214, 90, 27, 27, 14, 110, 101, 80, 255, 186, 63, 62, 14, 209, 139, 236, 117, 206, 242, 48, 238, 24, 63, 114, 245, 140, 130, 241, 82, 212, 28, 50, 65, 2, 7, 74, 167, 24, 24, 106, 29, 180, 4, 10, 173, 245, 5, 22, 171, 54, 0, 24, 38, 50, 158, 113, 188, 71, 108, 14, 185, 176, 122, 117, 208, 247, 244, 129, 9, 173, 218, 230, 199, 131, 99, 189, 174, 190, 26, 42, 117, 230, 164, 202, 58, 88, 218, 88, 46, 158, 137, 77, 113, 233, 33, 66, 223, 159, 26, 213, 42, 209, 130, 48, 137, 84, 29, 112, 214, 217, 37, 127, 181, 251, 212, 46, 83 },
                            Username = "merisa"
                        });
                });

            modelBuilder.Entity("NormativeCalculator.Database.Entities.Recipe", b =>
                {
                    b.HasOne("NormativeCalculator.Database.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NormativeCalculator.Database.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

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
