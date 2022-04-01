using FilesManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace FilesManagement.Context
{
    
    public partial class FileDbContext : DbContext
    {
        public FileDbContext()
        {
        }

        public FileDbContext(DbContextOptions<FileDbContext> options)
            : base(options)
        {
        }


        public virtual DbSet<FileData> FileData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 
                optionsBuilder.UseSqlServer("Server=DESKTOP-C454P2Q\\SQLEXPRESS;Database=FilesManagement;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");



            modelBuilder.Entity<FileData>(entity =>
            {
                entity.Property(e => e.FileExtension).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(500);

                entity.Property(e => e.FilePath).HasMaxLength(500);

                entity.Property(e => e.MimeType).HasMaxLength(50);

                entity.Property(e => e.FileSize).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
