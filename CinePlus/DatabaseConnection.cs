using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CinePlus
{
    public partial class DatabaseConnection : DbContext
    {
        public DatabaseConnection()
            : base("name=DatabaseConnection")
        {
        }

        public virtual DbSet<Movy> Movies { get; set; }
        public virtual DbSet<Ranking> Rankings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movy>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Movy>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Movy>()
                .Property(e => e.Synopsis)
                .IsUnicode(false);

            modelBuilder.Entity<Movy>()
                .Property(e => e.DirectorName)
                .IsUnicode(false);

            modelBuilder.Entity<Movy>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Movy>()
                .HasMany(e => e.Rankings)
                .WithRequired(e => e.Movy)
                .HasForeignKey(e => e.MovieId)
                .WillCascadeOnDelete(false);
        }
    }
}
