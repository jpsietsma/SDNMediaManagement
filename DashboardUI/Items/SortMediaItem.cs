using System.Data.Entity;
using SDNMediaModels.Sort;

namespace DashboardUI.Items
{
    
    public partial class SortMediaItem : DbContext
    {
        public SortMediaItem()
            : base("name=SortMediaItemConnection")
        {
        }

        public virtual DbSet<SortMediaItemModel> sortItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SortMediaItemModel>()
                .Property(e => e.pk_MediaID);

            modelBuilder.Entity<SortMediaItemModel>()
                .Property(e => e.filePath)
                .IsUnicode(false);

            modelBuilder.Entity<SortMediaItemModel>()
                .Property(e => e.fileName)
                .IsUnicode(false);

            modelBuilder.Entity<SortMediaItemModel>()
                .Property(e => e.fileNameSanitized)
                .IsUnicode(false);

            modelBuilder.Entity<SortMediaItemModel>()
                .Property(e => e.fileAdded);

            modelBuilder.Entity<SortMediaItemModel>()
                .Property(e => e.fileModified);

            modelBuilder.Entity<SortMediaItemModel>()
                .Property(e => e.fk_fileMediaTypeID);

        }
    }
}
