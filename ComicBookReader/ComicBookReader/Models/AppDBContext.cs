using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ComicBookReader.Models
{
    // Add-Migration название_миграции
    // Update-Database
    public class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ComicBook> ComicBooks { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<ComicPage> ComicPages { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ComicBook_User> ComicBook_Users { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // использование Fluent API
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ComicBook_User>().HasKey(cbu => new
            {
                cbu.ComicBookId,
                cbu.UserId
            });
            modelBuilder.Entity<User>().Property(u => u.UserImage).HasDefaultValue("/img/user_logo.png");
        }
    }

    public static class EntityExt
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            dbSet.RemoveRange(dbSet);
        }

    }
}
