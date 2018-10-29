using System.Data.Entity;
using SDNMediaModels.Television;

namespace DashboardUI.Items
{
   
    public partial class TelevisionSeasonItem : DbContext
    {
        public TelevisionSeasonItem()
            : base("name=TelevisionShowConnection")
        {
        }

        public virtual DbSet<TelevisionSeasonModel> sdnTelevisionSeasons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TelevisionSeasonModel>()
                .Property(e => e.pk_SeasonID);

            modelBuilder.Entity<TelevisionSeasonModel>()
                .Property(e => e.SeasonName)
                .IsUnicode(false);

            modelBuilder.Entity<TelevisionSeasonModel>()
                .Property(e => e.SeasonHomePath)
                .IsUnicode(false);

            modelBuilder.Entity<TelevisionSeasonModel>()
                .Property(e => e.SeasonNumEpisodes);

            modelBuilder.Entity<TelevisionSeasonModel>()
                .Property(e => e.IsEnabled);

            modelBuilder.Entity<TelevisionSeasonModel>()
                .Property(e => e.fk_ShowID);

            modelBuilder.Entity<TelevisionSeasonModel>()
                .Property(e => e.ShowName)
                .IsUnicode(false);

        }

    }
}
