using SDNMediaModels.Television;
using System.Data.Entity;

namespace DashboardUI.Items
{    
    public partial class TelevisionShowItem : DbContext
    {
        public TelevisionShowItem()
            : base("name=TelevisionShowConnection")
        {
        }

        //represents our list of television episodes
        /// <summary>
        /// List of Television Episodes
        /// </summary>
        public virtual DbSet<TelevisionEpisodeModel> sdnTelevisionEpisodes { get; set; }

        //represents our list of television seasons
        /// <summary>
        /// List of Television seasons
        /// </summary>
        public virtual DbSet<TelevisionSeasonModel> sdnTelevisionSeasons { get; set; }

        //represents our list of television shows
        /// <summary>
        /// List of Television shows
        /// </summary>
        public virtual DbSet<TelevisionShowModel> sdnTelevisionShows { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TelevisionShowModel>()
                .Property(e => e.pk_ShowID);

            modelBuilder.Entity<TelevisionShowModel>()
                .Property(e => e.IsEnabled);

            modelBuilder.Entity<TelevisionShowModel>()
                .Property(e => e.ShowName)
                .IsUnicode(false);

            modelBuilder.Entity<TelevisionShowModel>()
                .Property(e => e.ShowDriveLetter)
                .IsUnicode(false);

            modelBuilder.Entity<TelevisionShowModel>()
                .Property(e => e.ShowHomePath)
                .IsUnicode(false);

            modelBuilder.Entity<TelevisionShowModel>()
                .Property(e => e.ShowNumSeasons);

            modelBuilder.Entity<TelevisionShowModel>()
                .Property(e => e.ShowNumEpisodes);

        }

    }
}
