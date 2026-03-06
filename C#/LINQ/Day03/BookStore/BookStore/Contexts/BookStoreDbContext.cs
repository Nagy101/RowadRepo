using BookStore.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Contexts
{
    public class BookStoreDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Server=DESKTOP-JEP9L5L\\SQLEXPRESS;Database=BookstoreDB;Trusted_Connection=True;TrustServerCertificate=True;"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .HasMaxLength(150)
                .IsRequired();

            modelBuilder.Entity<Book>()
                .Property(b => b.Price)
                .HasColumnType("decimal(8,2)");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
