namespace HW8.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ArtistContext : DbContext
    {
        public ArtistContext()
            : base("name=ArtistContext")
        {
        }

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<ArtWork> ArtWorks { get; set; }
        public virtual DbSet<Classification> Classifications { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .Property(e => e.ArtistName)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .Property(e => e.BirthDate)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .Property(e => e.BirthCity)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .HasMany(e => e.ArtWorks)
                .WithRequired(e => e.Artist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ArtWork>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<ArtWork>()
                .HasMany(e => e.Classifications)
                .WithRequired(e => e.ArtWork)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genre>()
                .Property(e => e.GenreName)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Classifications)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);
        }
    }
}
