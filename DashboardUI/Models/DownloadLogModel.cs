namespace DashboardUI.Areas.LogsDashboard.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DownloadLogModel : DbContext
    {
        public DownloadLogModel()
            : base("name=DownloadLogModel")
        {
        }

        public virtual DbSet<downloadHistory> downloadHistories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<downloadHistory>()
                .Property(e => e.filePath)
                .IsUnicode(false);

            modelBuilder.Entity<downloadHistory>()
                .Property(e => e.fileName)
                .IsUnicode(false);

            modelBuilder.Entity<downloadHistory>()
                .Property(e => e.fileMediaType)
                .IsUnicode(false);

            modelBuilder.Entity<downloadHistory>()
                .Property(e => e.fileCreated)
                .HasPrecision(3);

            modelBuilder.Entity<downloadHistory>()
                .Property(e => e.fileCompleted)
                .HasPrecision(3);
        }
    }
}
