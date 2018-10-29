using System.Data.Entity;
using SDNMediaModels.Television;

namespace DashboardUI.Items
{
    
    public partial class TelevisionEpisodeItem : DbContext
    {
        public TelevisionEpisodeItem()
            : base("name=TelevisionShowConnection")
        {
        }

        public virtual DbSet<TelevisionEpisodeModel> sdnTelevisionEpisodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TelevisionEpisodeModel>()
                .Property(e => e.pk_EpisodeID);

            modelBuilder.Entity<TelevisionEpisodeModel>()
                .Property(e => e.IsEnabled);

            modelBuilder.Entity<TelevisionEpisodeModel>()
                .Property(e => e.SeasonName)
                .IsUnicode(false);

            modelBuilder.Entity<TelevisionEpisodeModel>()
                .Property(e => e.EpisodePath)
                .IsUnicode(false);

            modelBuilder.Entity<TelevisionEpisodeModel>()
                .Property(e => e.EpisodeAlbumArtPath)
                .IsUnicode(false);

            modelBuilder.Entity<TelevisionEpisodeModel>()
                .Property(e => e.EpisodePlayerPath)
                .IsUnicode(false);

            modelBuilder.Entity<TelevisionEpisodeModel>()
                .Property(e => e.SeasonHomePath)
                .IsUnicode(false);

            modelBuilder.Entity<TelevisionEpisodeModel>()
                .Property(e => e.ShowHomePath)
                .IsUnicode(false);

            modelBuilder.Entity<TelevisionEpisodeModel>()
                .Property(e => e.ShowName)
                .IsUnicode(false);

            modelBuilder.Entity<TelevisionEpisodeModel>()
                .Property(e => e.fk_SeasonID);

            modelBuilder.Entity<TelevisionEpisodeModel>()
                .Property(e => e.EpisodeNum);

            modelBuilder.Entity<TelevisionEpisodeModel>()
                 .Property(e => e.EpisodeDisplayTitle);

            modelBuilder.Entity<TelevisionEpisodeModel>()
                .Property(e => e.fk_ShowID);

        }

    }
}
