using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ComicBookReader.Models
{
    // Add-Migration название_миграции
    // Update-Database
    public class ComicBookReaderContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ComicBook> ComicBooks { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<ComicPage> ComicPages { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ComicBook_User> ComicBook_Users { get; set; }

        public ComicBookReaderContext(DbContextOptions<ComicBookReaderContext> options) : base(options)
        {
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
        }

    }
}
