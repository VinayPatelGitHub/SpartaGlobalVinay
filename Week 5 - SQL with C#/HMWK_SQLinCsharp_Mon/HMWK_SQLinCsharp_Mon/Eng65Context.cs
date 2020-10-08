using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HMWK_SQLinCsharp_Mon
{
    public partial class Eng65Context : DbContext
    {
        public Eng65Context()
        {
        }

        public Eng65Context(DbContextOptions<Eng65Context> options)
            : base(options)
        {
        }

        public virtual DbSet<FilmTable> FilmTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Eng65;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmTable>(entity =>
            {
                entity.HasKey(e => e.FilmId)
                    .HasName("PK__film_tab__6D1D229C29438671");

                entity.ToTable("film_table");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.DateOfRelease)
                    .HasColumnName("Date_of_Release")
                    .HasColumnType("date");

                entity.Property(e => e.Director)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FilmLanguage)
                    .HasColumnName("Film_Language")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FilmName)
                    .HasColumnName("Film_Name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FilmType)
                    .HasColumnName("Film_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OfficalWebsite)
                    .HasColumnName("Offical_Website")
                    .IsUnicode(false);

                entity.Property(e => e.PlotSummart)
                    .HasColumnName("Plot_Summart")
                    .IsUnicode(false);

                entity.Property(e => e.Star)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Writer)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
