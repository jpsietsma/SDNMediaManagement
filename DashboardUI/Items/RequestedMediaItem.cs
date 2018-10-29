using System.Data.Entity;
using SDNMediaModels.Feedback;

namespace DashboardUI.Items
{
    
    public partial class RequestedMediaItem : DbContext
    {
        public RequestedMediaItem()
            : base("name=TelevisionShowConnection")
        {
        }

        public virtual DbSet<RequestedMediaItemModel> requests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequestedMediaItemModel>()
                .Property(e => e.pk_RequestID);

            modelBuilder.Entity<RequestedMediaItemModel>()
                .Property(e => e.RequestType);

            modelBuilder.Entity<RequestedMediaItemModel>()
                .Property(e => e.RequestSubtype);

            modelBuilder.Entity<RequestedMediaItemModel>()
                .Property(e => e.ExistingSeries);

            modelBuilder.Entity<RequestedMediaItemModel>()
                .Property(e => e.RequestQuery);

            modelBuilder.Entity<RequestedMediaItemModel>()
                .Property(e => e.RequestShow);

            modelBuilder.Entity<RequestedMediaItemModel>()
                .Property(e => e.RequestSeason);

            modelBuilder.Entity<RequestedMediaItemModel>()
                .Property(e => e.RequestEpisode);

            modelBuilder.Entity<RequestedMediaItemModel>()
                .Property(e => e.RequestMovie);

            modelBuilder.Entity<RequestedMediaItemModel>()
                .Property(e => e.RequestMovieYear);

            modelBuilder.Entity<RequestedMediaItemModel>()
                .Property(e => e.RequestMovieGenre);

            modelBuilder.Entity<RequestedMediaItemModel>()
                .Property(e => e.RequestCompleted);

        }
    }
}
