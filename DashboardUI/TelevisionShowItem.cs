namespace DashboardUI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TelevisionShowItem : DbContext
    {
        public TelevisionShowItem()
            : base("name=TelevisionShowConnection")
        {
        }

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
