using System;
using System.Collections.Generic;
using System.Text;
using Domain.Articles;
using Domain.Categories;
using Domain.Comments;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Shared
{
    public class DatabaseContext : DbContext, IDatabaseContext {

        public DatabaseContext(DbContextOptions options) : base(options) {
            //Database.SetInitializer(new DatabaseInitializer());
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }

        public void Save() {
            this.SaveChanges();
        }

        DbSet<T> IDatabaseContext.Set<T>() {
            return base.Set<T>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //Seed Categories
            var categories = new Category[] {
                new Category() { Id = 1, Name = "Miscellaneous" },
                new Category() { Id = 2, Name = "Programming" },
                new Category() { Id = 3, Name = "Video Games" },
                new Category() { Id = 4, Name = "Sports" } };

            modelBuilder.Entity<Category>().HasData(categories);

            //Seed Article 
            modelBuilder.Entity<Article>().HasData(
                new  {
                     Id = 1,
                     Name = "Welcome",
                     CategoryId = categories[0].Id,
                     Content = "First Article",
                     DateCreated = DateTime.UtcNow,
                     DateUpdated = DateTime.UtcNow
                });
        }
    }
}
