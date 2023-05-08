using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.Database.DataSeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database.EF
{
    public class NormativeCalculatorDbContext : DbContext
    {
        public NormativeCalculatorDbContext(DbContextOptions<NormativeCalculatorDbContext> options) : base(options)
        {
        }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RecipeIngredients>().HasKey(r => new { r.IngredientId, r.RecipeId });
            modelBuilder.DataSeed();
        }

    }
}
