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
    [Migration("20220613083003_measue")]
    partial class measue
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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2022, 6, 13, 10, 30, 3, 216, DateTimeKind.Local).AddTicks(1591),
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
                            PasswordHash = new byte[] { 101, 6, 37, 54, 230, 249, 144, 10, 110, 71, 47, 68, 47, 59, 42, 70, 33, 78, 105, 203, 127, 32, 68, 75, 125, 78, 184, 67, 143, 16, 195, 208, 246, 47, 88, 190, 12, 222, 92, 151, 113, 36, 34, 58, 101, 94, 248, 240, 30, 254, 136, 218, 76, 197, 136, 231, 72, 173, 20, 172, 108, 165, 115, 189 },
                            PasswordSalt = new byte[] { 8, 27, 76, 217, 129, 191, 112, 42, 55, 225, 22, 102, 120, 176, 225, 207, 139, 166, 140, 159, 79, 109, 226, 19, 172, 81, 253, 8, 196, 12, 95, 33, 229, 16, 47, 164, 197, 126, 87, 69, 251, 37, 107, 147, 251, 143, 209, 29, 82, 26, 45, 143, 165, 165, 42, 251, 228, 149, 112, 175, 181, 225, 153, 206, 119, 50, 178, 222, 149, 22, 2, 252, 156, 29, 75, 3, 246, 19, 35, 17, 213, 117, 34, 41, 127, 54, 4, 193, 188, 109, 179, 43, 123, 65, 14, 229, 220, 173, 88, 151, 178, 239, 116, 57, 28, 10, 68, 23, 220, 230, 153, 220, 121, 20, 145, 210, 205, 179, 228, 12, 189, 126, 66, 207, 125, 149, 70, 53 },
                            Username = "sanjin"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Merisa",
                            LastName = "Mulac",
                            PasswordHash = new byte[] { 33, 46, 52, 150, 121, 122, 12, 216, 12, 38, 64, 16, 203, 142, 236, 143, 79, 200, 229, 65, 138, 114, 92, 13, 149, 234, 180, 145, 16, 65, 255, 81, 66, 210, 74, 183, 139, 26, 91, 20, 16, 231, 255, 232, 196, 98, 156, 14, 169, 131, 74, 130, 124, 31, 188, 180, 33, 222, 71, 158, 134, 130, 220, 126 },
                            PasswordSalt = new byte[] { 8, 27, 76, 217, 129, 191, 112, 42, 55, 225, 22, 102, 120, 176, 225, 207, 139, 166, 140, 159, 79, 109, 226, 19, 172, 81, 253, 8, 196, 12, 95, 33, 229, 16, 47, 164, 197, 126, 87, 69, 251, 37, 107, 147, 251, 143, 209, 29, 82, 26, 45, 143, 165, 165, 42, 251, 228, 149, 112, 175, 181, 225, 153, 206, 119, 50, 178, 222, 149, 22, 2, 252, 156, 29, 75, 3, 246, 19, 35, 17, 213, 117, 34, 41, 127, 54, 4, 193, 188, 109, 179, 43, 123, 65, 14, 229, 220, 173, 88, 151, 178, 239, 116, 57, 28, 10, 68, 23, 220, 230, 153, 220, 121, 20, 145, 210, 205, 179, 228, 12, 189, 126, 66, 207, 125, 149, 70, 53 },
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