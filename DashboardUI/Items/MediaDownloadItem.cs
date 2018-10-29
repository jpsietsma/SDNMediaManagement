using SDNMediaModels.Download;
using System.Data.Entity;

namespace DashboardUI.Items
{
    public class MediaDownloadItem : DbContext
    {

        public MediaDownloadItem()
                : base("name=TelevisionShowConnection")
        {
        }

        public virtual DbSet<MediaDownloadModel> sdnDownloadItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.pk_torrentID);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.TorrentName);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.DownloadStarted);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.DownloadFinished);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.TorrentPath);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.DownloadDuration);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.finalizedShowName);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.finalizedShowSeason);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.finalizedShowEpisode);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.fileNameSanitized);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.automationStatusDisplay);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.hasBeenProcessed);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.hasBeenSanitized);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.hasBeenFinalized);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.hasBeenDistributed);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.pk_MediaID);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.MediaTypeName);

            modelBuilder.Entity<MediaDownloadModel>()
                .Property(e => e.MoveDestination);

        }



    }
}