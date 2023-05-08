using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database.DataSeed
{
    public static class NormativeCalculatorContextSeed
    {
        public static void DataSeed(this ModelBuilder modelBuilder)
        {

            using var hmac = new HMACSHA512();
            modelBuilder.Entity<User>().HasData
        (
                new User
                {
                    Id = 1,
                    LastName = "Sabanovic",
                    FirstName = "Sanjin",
                    Username = "sanjin",
                    PasswordSalt = hmac.Key,
                    PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("Password"))
                }

                );
            modelBuilder.Entity<User>().HasData
  (
          new User
          {
              Id = 2,
              LastName = "Mulac",
              FirstName = "Merisa",
              Username = "merisa",
              PasswordSalt = hmac.Key,
              PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("Test"))
          },
           new User
           {
               Id = 3,
               LastName = "Duvnjak",
               FirstName = "Alema",
               Username = "alema",
               PasswordSalt = hmac.Key,
               PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("test1"))
           },
             new User
             {
                 Id = 4,
                 LastName = "Dedic",
                 FirstName = "Amra",
                 Username = "amra",
                 PasswordSalt = hmac.Key,
                 PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("test2"))
             },
                new User
                {
                    Id = 5,
                    LastName = "Lepir",
                    FirstName = "Mirza",
                    Username = "mirza",
                    PasswordSalt = hmac.Key,
                    PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("test3"))
                },
                   new User
                   {
                       Id = 6,
                       LastName = "Tulic",
                       FirstName = "Haris",
                       Username = "haris",
                       PasswordSalt = hmac.Key,
                       PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("test4"))
                   },
                    new User
                    {
                        Id = 7,
                        LastName = "Setka",
                        FirstName = "Nejra",
                        Username = "nejra",
                        PasswordSalt = hmac.Key,
                        PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("test5"))
                    }
          );
            modelBuilder.Entity<Category>().HasData
            (
            new Category
            {
                Id = 1,
                Name = "Pancakes",
                DateCreated = new DateTime(new Random().Next(2020, 2022), 3, 9),
                IsDeleted = false,
            },
            new Category
            {
                Id = 2,
                Name = "Waffles",
                DateCreated = new DateTime(new Random().Next(2020, 2022), 8, 9),
                IsDeleted = false
            },
              new Category
              {
                  Id = 3,
                  Name = "Cake",
                  DateCreated = new DateTime(new Random().Next(2020, 2022), 9, 9),
                  IsDeleted = false

              },
                new Category
                {
                    Id = 4,
                    Name = "Lava cake",
                    DateCreated = new DateTime(new Random().Next(2019, 2022), 7, 9),
                    IsDeleted = false
                },
                new Category
                {
                    Id = 5,
                    Name = "Muffin",
                    DateCreated = new DateTime(new Random().Next(2022, 2022), 5, 9),
                    IsDeleted = false
                },
                   new Category
                   {
                       Id = 6,
                       Name = "Carrot cake",
                       DateCreated = new DateTime(new Random().Next(2022, 2022), 5, 6),
                       IsDeleted = false
                   },
                    new Category
                    {
                        Id = 7,
                        Name = "Cheesecake",
                        DateCreated = new DateTime(new Random().Next(2022, 2022), 1, 11),
                        IsDeleted = false
                    },
                        new Category
                        {
                            Id = 8,
                            Name = "Coffee Cake Recipes",
                            DateCreated = new DateTime(new Random().Next(2022, 2022), 8, 10),
                            IsDeleted = false
                        },
                         new Category
                         {
                             Id = 9,
                             Name = "Coconut Cake",
                             DateCreated = new DateTime(new Random().Next(2022, 2022), 2, 10),
                             IsDeleted = false
                         },
                           new Category
                           {
                               Id = 10,
                               Name = "Cupcakes",
                               DateCreated = new DateTime(new Random().Next(2022, 2022), 5, 1),
                               IsDeleted = false
                           },
                                new Category
                                {
                                    Id = 11,
                                    Name = "Fruitcake",
                                    DateCreated = new DateTime(new Random().Next(2022, 2022), 7, 8),
                                    IsDeleted = false
                                },
                                  new Category
                                  {
                                      Id = 12,
                                      Name = "Holiday cake",
                                      DateCreated = new DateTime(new Random().Next(2022, 2022), 5, 3),
                                      IsDeleted = false
                                  }

             );
            modelBuilder.Entity<Ingredient>().HasData
       (
       new Ingredient
       {
           Id = 1,
           Name = "Suger",
           Price = 2,
           Quantity = 100,
           MeasureType = Common.Enum.MeasureType.gr,
           IsDeleted = false
       },
        new Ingredient
        {
            Id = 2,
            Name = "Flour",
            Price = 6,
            Quantity = 100,
            MeasureType = Common.Enum.MeasureType.ml,
            IsDeleted = false
        },
          new Ingredient
          {
              Id = 3,
              Name = "Egg",
              Price = 2,
              Quantity = 2,
              MeasureType = Common.Enum.MeasureType.kom,
              IsDeleted = false
          },
            new Ingredient
            {
                Id = 4,
                Name = "Brown suger",
                Price = 2,
                Quantity = 200,
                MeasureType = Common.Enum.MeasureType.gr,
                IsDeleted = false
            },
             new Ingredient
             {
                 Id = 5,
                 Name = "Milk",
                 Price = 1,
                 Quantity = 200,
                 MeasureType = Common.Enum.MeasureType.ml,
                 IsDeleted = false
             },
               new Ingredient
               {
                   Id = 6,
                   Name = "Water",
                   Price = 2,
                   Quantity = 1,
                   MeasureType = Common.Enum.MeasureType.ml,
                   IsDeleted = false
               },
                new Ingredient
                {
                    Id = 7,
                    Name = "Buter",
                    Price = 4,
                    Quantity = 350,
                    MeasureType = Common.Enum.MeasureType.gr,
                    IsDeleted = false
                },
                new Ingredient
                {
                    Id = 8,
                    Name = "Walnut",
                    Price = 10,
                    Quantity = 2,
                    MeasureType = Common.Enum.MeasureType.kg,
                    IsDeleted = false
                },
                 new Ingredient
                 {
                     Id = 9,
                     Name = "Banana",
                     Price = 3,
                     Quantity = 5,
                     MeasureType = Common.Enum.MeasureType.kom,
                     IsDeleted = false
                 },
                  new Ingredient
                  {
                      Id = 10,
                      Name = "Salt",
                      Price = 1,
                      Quantity = 1,
                      MeasureType = Common.Enum.MeasureType.gr,
                      IsDeleted = false
                  },
                     new Ingredient
                     {
                         Id = 11,
                         Name = "Strawberries",
                         Price = 15,
                         Quantity = 1,
                         MeasureType = Common.Enum.MeasureType.kg,
                         IsDeleted = false

                     },
                     new Ingredient
                     {
                         Id = 12,
                         Name = "Baking powder",
                         Price = 4,
                         Quantity = 1,
                         MeasureType = Common.Enum.MeasureType.gr,
                         IsDeleted = false

                     },
                       new Ingredient
                       {
                           Id = 13,
                           Name = "Blueberry",
                           Price = 12,
                           Quantity = 1,
                           MeasureType = Common.Enum.MeasureType.kg,
                           IsDeleted = false

                       },
                       new Ingredient
                       {
                           Id = 14,
                           Name = "Vanilla extract",
                           Price = 6,
                           Quantity = 1,
                           MeasureType = Common.Enum.MeasureType.kom,
                           IsDeleted = false

                       },
                          new Ingredient
                          {
                              Id = 15,
                              Name = "Caramel",
                              Price = 11,
                              Quantity = 1,
                              MeasureType = Common.Enum.MeasureType.gr,
                              IsDeleted = false

                          },
                          new Ingredient
                          {
                              Id = 16,
                              Name = "Honey",
                              Price = 40,
                              Quantity = 1,
                              MeasureType = Common.Enum.MeasureType.kg,
                              IsDeleted = false

                          },
                             new Ingredient
                             {
                                 Id = 17,
                                 Name = "Baking soda",
                                 Price = 12,
                                 Quantity = 1,
                                 MeasureType = Common.Enum.MeasureType.gr,
                                 IsDeleted = false

                             }

                     );
            modelBuilder.Entity<Recipe>().HasData
    (
            new Recipe
            {
                Id = 1,
                CategoryId = 1,
                DateCreated = new DateTime(new Random().Next(2022, 2022), 5, 9),
                Description = "This easy American pancake recipe makes light and fluffy pancakes that are great for a weekend brunch.",
                IsDeleted = false,
                Name = "Lite Carrot Cake",
                UserId = 1
            },
             new Recipe
             {
                 Id = 2,
                 CategoryId = 6,
                 DateCreated = new DateTime(new Random().Next(2022, 2022), 5, 9),
                 Description = "Pipe royal icing carrots on parchment to decorate your cake.",
                 IsDeleted = false,
                 Name = "Royal Icing Carrots",
                 UserId = 2
             },
                  new Recipe
                  {
                      Id = 3,
                      CategoryId = 7,
                      DateCreated = new DateTime(new Random().Next(2022, 2022), 7, 9),
                      Description = "This is a great recipe that gets compliments when ever I make it..",
                      IsDeleted = false,
                      Name = "Brownie Caramel Cheesecake",
                      UserId = 2
                  },
                  new Recipe
                  {
                      Id = 4,
                      CategoryId = 7,
                      DateCreated = new DateTime(new Random().Next(2022, 2022), 5, 1),
                      Description = "Love lemon meringue pie and cheesecake?",
                      IsDeleted = false,
                      Name = "Lemon Meringue Cheesecake",
                      UserId = 5
                  },
                       new Recipe
                       {
                           Id = 5,
                           CategoryId = 8,
                           DateCreated = new DateTime(new Random().Next(2022, 2022), 3, 9),
                           Description = "Love lemon meringue pie and cheesecake?",
                           IsDeleted = false,
                           Name = "Blueberry Buttermilk Coffeecake",
                           UserId = 7
                       },
                       new Recipe
                       {
                           Id = 6,
                           CategoryId = 8,
                           DateCreated = new DateTime(new Random().Next(2022, 2022), 3, 9),
                           Description = "This is really easy and so very, very good.",
                           IsDeleted = false,
                           Name = "Apple Coffee Cake",
                           UserId = 3
                       },
                        new Recipe
                        {
                            Id = 7,
                            CategoryId = 9,
                            DateCreated = new DateTime(new Random().Next(2022, 2022), 1, 9),
                            Description = "A moist coconut pound cake, a crowd pleaser.",
                            IsDeleted = false,
                            Name = "Coconut Cream Pound Cake",
                            UserId = 4
                        },
                           new Recipe
                           {
                               Id = 8,
                               CategoryId = 9,
                               DateCreated = new DateTime(new Random().Next(2022, 2022), 9, 9),
                               Description = "Coconut oil is the special ingredient in these delicately flavored, tender cupcakes. Garnish with a slice of fresh Key lime if desired.",
                               IsDeleted = false,
                               Name = "Coconut Cupcakes",
                               UserId = 5
                           },
                            new Recipe
                            {
                                Id = 9,
                                CategoryId = 10,
                                DateCreated = new DateTime(new Random().Next(2022, 2022), 2, 20),
                                Description = "This simple white cake recipe uses just 7 ingredients.",
                                IsDeleted = false,
                                Name = "Simple White Cake",
                                UserId = 5
                            },
                                new Recipe
                                {
                                    Id = 10,
                                    CategoryId = 10,
                                    DateCreated = new DateTime(new Random().Next(2022, 2022), 11, 11),
                                    Description = "A cinnamon sugary cupcake reminiscent of the deep - fried Mexican dessert!.",
                                    IsDeleted = false,
                                    Name = "Sopapilla Cupcakes",
                                    UserId = 6
                                },
                                 new Recipe
                                 {
                                     Id = 11,
                                     CategoryId = 11,
                                     DateCreated = new DateTime(new Random().Next(2022, 2022), 7, 18),
                                     Description = "This has been a favorite of my husband's since I can long remember.",
                                     IsDeleted = false,
                                     Name = "English Walnut Date Cake",
                                     UserId = 3
                                 },
                                  new Recipe
                                  {
                                      Id = 12,
                                      CategoryId = 11,
                                      DateCreated = new DateTime(new Random().Next(2022, 2022), 4, 3),
                                      Description = "This is a large recipe that is rich and dark.",
                                      IsDeleted = false,
                                      Name = "Festive Fruitcakee",
                                      UserId = 3
                                  },
                                   new Recipe
                                   {
                                       Id = 13,
                                       CategoryId = 12,
                                       DateCreated = new DateTime(new Random().Next(2022, 2022), 1, 3),
                                       Description = "A sweet biscuit-style shortcake with two layers of juicy strawberries and cream.",
                                       IsDeleted = false,
                                       Name = "Strawberry Shortcake",
                                       UserId = 2
                                   }
            );
            modelBuilder.Entity<RecipeIngredients>().HasData
(
  new RecipeIngredients
  {

      RecipeId = 1,
      IngredientId = 3,
      MeasureType = Common.Enum.MeasureType.kom,
      Quantity = 3,

  },
    new RecipeIngredients
    {

        RecipeId = 2,
        IngredientId = 3,
        MeasureType = Common.Enum.MeasureType.kg,
        Quantity = 3,

    },
     new RecipeIngredients
     {

         RecipeId = 2,
         IngredientId = 5,
         MeasureType = Common.Enum.MeasureType.ml,
         Quantity = 2,

     },
      new RecipeIngredients
      {

          RecipeId = 3,
          IngredientId = 5,
          MeasureType = Common.Enum.MeasureType.l,
          Quantity = 4,

      },
       new RecipeIngredients
       {

           RecipeId = 3,
           IngredientId = 7,
           MeasureType = Common.Enum.MeasureType.gr,
           Quantity = 700
       },
         new RecipeIngredients
         {

             RecipeId = 4,
             IngredientId = 7,
             MeasureType = Common.Enum.MeasureType.kg,
             Quantity = 2
         },
             new RecipeIngredients
             {

                 RecipeId = 4,
                 IngredientId = 2,
                 MeasureType = Common.Enum.MeasureType.ml,
                 Quantity = 600
             },
               new RecipeIngredients
               {

                   RecipeId = 5,
                   IngredientId = 6,
                   MeasureType = Common.Enum.MeasureType.l,
                   Quantity = 1
               },
                new RecipeIngredients
                {

                    RecipeId = 5,
                    IngredientId = 11,
                    MeasureType = Common.Enum.MeasureType.ml,
                    Quantity = 3
                },
                    new RecipeIngredients
                    {

                        RecipeId = 6,
                        IngredientId = 10,
                        MeasureType = Common.Enum.MeasureType.gr,
                        Quantity = 2
                    },
                     new RecipeIngredients
                     {

                         RecipeId = 6,
                         IngredientId = 13,
                         MeasureType = Common.Enum.MeasureType.gr,
                         Quantity = 5
                     },
                          new RecipeIngredients
                          {

                              RecipeId = 7,
                              IngredientId = 17,
                              MeasureType = Common.Enum.MeasureType.gr,
                              Quantity = 150
                          },
                           new RecipeIngredients
                           {

                               RecipeId = 7,
                               IngredientId = 16,
                               MeasureType = Common.Enum.MeasureType.gr,
                               Quantity = 600
                           },
                            new RecipeIngredients
                            {

                                RecipeId = 8,
                                IngredientId = 15,
                                MeasureType = Common.Enum.MeasureType.kg,
                                Quantity = 1
                            },
                           new RecipeIngredients
                           {

                               RecipeId = 8,
                               IngredientId = 14,
                               MeasureType = Common.Enum.MeasureType.gr,
                               Quantity = 200
                           },
                              new RecipeIngredients
                              {

                                  RecipeId = 9,
                                  IngredientId = 13,
                                  MeasureType = Common.Enum.MeasureType.kom,
                                  Quantity = 10
                              },
                           new RecipeIngredients
                           {

                               RecipeId = 10,
                               IngredientId = 12,
                               MeasureType = Common.Enum.MeasureType.gr,
                               Quantity = 300
                           },
                            new RecipeIngredients
                            {

                                RecipeId = 11,
                                IngredientId = 12,
                                MeasureType = Common.Enum.MeasureType.gr,
                                Quantity = 300
                            },
                                 new RecipeIngredients
                                 {

                                     RecipeId = 12,
                                     IngredientId = 9,
                                     MeasureType = Common.Enum.MeasureType.gr,
                                     Quantity = 300
                                 },
                                      new RecipeIngredients
                                      {

                                          RecipeId = 13,
                                          IngredientId = 13,
                                          MeasureType = Common.Enum.MeasureType.gr,
                                          Quantity = 300
                                      },
                                           new RecipeIngredients
                                           {

                                               RecipeId = 13,
                                               IngredientId = 8,
                                               MeasureType = Common.Enum.MeasureType.ml,
                                               Quantity = 100
                                           }


  );

        }
    }
}
