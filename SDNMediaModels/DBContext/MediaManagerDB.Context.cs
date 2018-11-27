using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using SDNMediaModels.Api;
using SDNMediaModels.Account;
using SDNMediaModels.Feedback;
using SDNMediaModels.Logs;
using SDNMediaModels.List;
using SDNMediaModels.Sort;
using SDNMediaModels.Television;
using SDNMediaModels.StoredProcedure;
using SDNMediaModels.Movies;
using SDNMediaModels.DBViews;

namespace SDNMediaModels.DBContext
{

    /// <summary>
    /// Class to handle connections to SDN Media Manager database
    /// </summary>
    public partial class MediaManagerDB : DbContext
    {

        /// <summary>
        /// Create connection instance to SDN Media Manager database
        /// </summary>
        public MediaManagerDB()
            : base("name=MediaManagerDB")
        {
        }

        /// <summary>
        /// No Metadata necessary for OnModelCreating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        /// <summary>
        /// API tokens associated with user accounts
        /// </summary>
        public virtual DbSet<ApiToken> ApiTokens { get; set; }

        /// <summary>
        /// System user roles
        /// </summary>
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

        /// <summary>
        /// Claims associated with user accounts
        /// </summary>
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

        /// <summary>
        /// Logins associated with user accounts
        /// </summary>
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

        /// <summary>
        /// SDN Media Manager system users
        /// </summary>
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

        /// <summary>
        /// SDN Media Manager downloads and history
        /// </summary>
        public virtual DbSet<DownloadQueue> DownloadQueues { get; set; }

        /// <summary>
        /// File move log histories
        /// </summary>
        public virtual DbSet<FileMoveHistory> FileMoveHistories { get; set; }

        /// <summary>
        /// List of actions that automation recognizes and can complete
        /// </summary>
        public virtual DbSet<list_AutomationActions> list_AutomationActions { get; set; }

        /// <summary>
        /// List of priorities that can be assigned to any automation actions
        /// </summary>
        public virtual DbSet<list_AutomationPriority> list_AutomationPriority { get; set; }

        /// <summary>
        /// List of status that can be assigned to any automation action
        /// </summary>
        public virtual DbSet<list_AutomationStatuses> list_AutomationStatuses { get; set; }

        /// <summary>
        /// List of storage drives that store content in the media libraries
        /// </summary>
        public virtual DbSet<list_MediaDrives> list_MediaDrives { get; set; }

        /// <summary>
        /// List of classification subtypes associated with various media library items
        /// </summary>
        public virtual DbSet<list_MediaSubTypes> list_MediaSubTypes { get; set; }

        /// <summary>
        /// List of classification types associated with various media library items
        /// </summary>
        public virtual DbSet<list_MediaTypes> list_MediaTypes { get; set; }

        /// <summary>
        /// List of genres that can be assigned to library movies
        /// </summary>
        public virtual DbSet<list_MovieGenres> list_MovieGenres { get; set; }

        /// <summary>
        /// List of permission levels that control various system functions
        /// </summary>
        public virtual DbSet<list_permissionLevels> list_permissionLevels { get; set; }

        /// <summary>
        /// List of automation tasks that can be completed (tasks are sort cleanup, meta data refresh and gathering, nothing that touches live libraries)
        /// </summary>
        public virtual DbSet<list_TaskTypes> list_TaskTypes { get; set; }

        /// <summary>
        /// List of Movies available in the system
        /// </summary>
        public virtual DbSet<Movie> Movies { get; set; }

        /// <summary>
        /// List of playback history for tv episodes and movies in the system
        /// </summary>
        public virtual DbSet<PlaybackHistory> PlaybackHistories { get; set; }

        /// <summary>
        /// Items that the automation will process, tasks, account creations, etc
        /// </summary>
        public virtual DbSet<ProcessQueue> ProcessQueues { get; set; }

        /// <summary>
        /// Items that need to be sorted and processed but are not in a live library
        /// </summary>
        public virtual DbSet<sortItem> sortItems { get; set; }

        /// <summary>
        /// List of tasks to be completed
        /// </summary>
        public virtual DbSet<TaskQueue> TaskQueues { get; set; }

        /// <summary>
        /// Television episodes added to the live library available in the system
        /// </summary>
        public virtual DbSet<TelevisionEpisode> TelevisionEpisodes { get; set; }

        /// <summary>
        /// Television Seasons added to the live library available in the system
        /// </summary>
        public virtual DbSet<TelevisionSeason> TelevisionSeasons { get; set; }

        /// <summary>
        /// Television Shows added to the live library available in the system
        /// </summary>
        public virtual DbSet<TelevisionShow> TelevisionShows { get; set; }

        /// <summary>
        /// List of requested media from system users
        /// </summary>
        public virtual DbSet<UserRequest> UserRequests { get; set; }

        /// <summary>
        /// List of shows being tracked by users and downloaded automatically by automation
        /// </summary>
        public virtual DbSet<TrackedShow> TrackedShows { get; set; }

        /// <summary>
        /// View showing user accounts and their associated permissions in the system
        /// </summary>
        public virtual DbSet<vw_UserAccountOverview> vw_UserAccountOverview { get; set; }
    
        /// <summary>
        /// Enable episode in user interface
        /// </summary>
        /// <param name="episodeID">pk_EpisodeID of episode to activate</param>
        /// <returns></returns>
        public virtual int ActivateEpisode(Nullable<int> episodeID)
        {
            var episodeIDParameter = episodeID.HasValue ?
                new ObjectParameter("episodeID", episodeID) :
                new ObjectParameter("episodeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActivateEpisode", episodeIDParameter);
        }
    
        /// <summary>
        /// Activate season in user interface
        /// </summary>
        /// <param name="seasonID">pk_SeasonID of season to activate</param>
        /// <returns></returns>
        public virtual int ActivateSeason(Nullable<int> seasonID)
        {
            var seasonIDParameter = seasonID.HasValue ?
                new ObjectParameter("seasonID", seasonID) :
                new ObjectParameter("seasonID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActivateSeason", seasonIDParameter);
        }
    
        /// <summary>
        /// Activate Television show in user interface
        /// </summary>
        /// <param name="showID">pk_ShowID of show to activate</param>
        /// <returns></returns>
        public virtual int ActivateShow(Nullable<int> showID)
        {
            var showIDParameter = showID.HasValue ?
                new ObjectParameter("showID", showID) :
                new ObjectParameter("showID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActivateShow", showIDParameter);
        }
    
        /// <summary>
        /// Build file source url to location of file to stream
        /// </summary>
        /// <param name="fileName">Display name of file to stream</param>
        /// <param name="showName">Show name of file to stream</param>
        /// <param name="showFile">File Name of episode to stream</param>
        /// <param name="showSeason">Seasont of file to stream</param>
        /// <returns>string representing url src of file to stream in HTML5 Media player</returns>
        public virtual ObjectResult<string> BuildEpisodeStreamingUrl(string fileName, string showName, string showFile, string showSeason)
        {
            var fileNameParameter = fileName != null ?
                new ObjectParameter("fileName", fileName) :
                new ObjectParameter("fileName", typeof(string));
    
            var showNameParameter = showName != null ?
                new ObjectParameter("showName", showName) :
                new ObjectParameter("showName", typeof(string));
    
            var showFileParameter = showFile != null ?
                new ObjectParameter("showFile", showFile) :
                new ObjectParameter("showFile", typeof(string));
    
            var showSeasonParameter = showSeason != null ?
                new ObjectParameter("showSeason", showSeason) :
                new ObjectParameter("showSeason", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("BuildEpisodeStreamingUrl", fileNameParameter, showNameParameter, showFileParameter, showSeasonParameter);
        }
    
        /// <summary>
        /// Deactivate Television Show in user interface
        /// </summary>
        /// <param name="showID">pk_ShowId of show to deactivate in user interface</param>
        /// <returns></returns>
        public virtual int DeactivateShow(Nullable<int> showID)
        {
            var showIDParameter = showID.HasValue ?
                new ObjectParameter("showID", showID) :
                new ObjectParameter("showID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeactivateShow", showIDParameter);
        }
    
        /// <summary>
        /// Get all shows in SDN Media Manager system
        /// </summary>
        /// <returns></returns>
        public virtual ObjectResult<GetAllShows_Result> GetAllShows()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllShows_Result>("GetAllShows");
        }
    
        /// <summary>
        /// Get all downloads from current day
        /// </summary>
        /// <returns></returns>
        public virtual ObjectResult<GetDailyDownloads_Result> GetDailyDownloads()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDailyDownloads_Result>("GetDailyDownloads");
        }
    
        /// <summary>
        /// Transform number of minutes into days/hours/minutes format
        /// </summary>
        /// <param name="mins">Total duration in minutes</param>
        /// <returns></returns>
        public virtual ObjectResult<string> GetDisplayDuration(Nullable<int> mins)
        {
            var minsParameter = mins.HasValue ?
                new ObjectParameter("mins", mins) :
                new ObjectParameter("mins", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetDisplayDuration", minsParameter);
        }
    
        /// <summary>
        /// Get all movies in SDN Media Manager system
        /// </summary>
        /// <returns></returns>
        public virtual ObjectResult<GetMovies_Result> GetMovies()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMovies_Result>("GetMovies");
        }
    
        /// <summary>
        /// Get Sort items which have not been classified to a show
        /// </summary>
        /// <returns></returns>
        public virtual ObjectResult<GetOrphanSortItems_Result> GetOrphanSortItems()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetOrphanSortItems_Result>("GetOrphanSortItems");
        }
    
        /// <summary>
        /// Get all episodes belonging to a show
        /// </summary>
        /// <param name="showID">pk_ShowID of show to get children episodes</param>
        /// <returns></returns>
        public virtual ObjectResult<GetShowEpisodes_Result> GetShowEpisodes(Nullable<int> showID)
        {
            var showIDParameter = showID.HasValue ?
                new ObjectParameter("showID", showID) :
                new ObjectParameter("showID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetShowEpisodes_Result>("GetShowEpisodes", showIDParameter);
        }
    
        /// <summary>
        /// Get all episodes of a particular season
        /// </summary>
        /// <param name="seasonID">pk_SeasonID of season to get children episodes</param>
        /// <returns></returns>
        public virtual ObjectResult<GetShowEpisodesBySeason_Result> GetShowEpisodesBySeason(Nullable<int> seasonID)
        {
            var seasonIDParameter = seasonID.HasValue ?
                new ObjectParameter("seasonID", seasonID) :
                new ObjectParameter("seasonID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetShowEpisodesBySeason_Result>("GetShowEpisodesBySeason", seasonIDParameter);
        }
    
        /// <summary>
        /// Get Show Id by name
        /// </summary>
        /// <param name="showName">Show Name</param>
        /// <param name="showID">pk_ShowID of show</param>
        /// <returns></returns>
        public virtual ObjectResult<Nullable<int>> GetShowIdByName(string showName, Nullable<int> showID)
        {
            var showNameParameter = showName != null ?
                new ObjectParameter("ShowName", showName) :
                new ObjectParameter("ShowName", typeof(string));
    
            var showIDParameter = showID.HasValue ?
                new ObjectParameter("ShowID", showID) :
                new ObjectParameter("ShowID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetShowIdByName", showNameParameter, showIDParameter);
        }
    
        /// <summary>
        /// Get all seasons belonging to a particular show
        /// </summary>
        /// <param name="showID">pk_ShowID of show to get children seasons</param>
        /// <returns></returns>
        public virtual ObjectResult<GetShowSeasons_Result> GetShowSeasons(Nullable<int> showID)
        {
            var showIDParameter = showID.HasValue ?
                new ObjectParameter("showID", showID) :
                new ObjectParameter("showID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetShowSeasons_Result>("GetShowSeasons", showIDParameter);
        }
    
        /// <summary>
        /// Get all sort items in SDN Media Manager system
        /// </summary>
        /// <returns></returns>
        public virtual ObjectResult<GetSortItems_Result> GetSortItems()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSortItems_Result>("GetSortItems");
        }
    
        /// <summary>
        /// Get all SDN Media Manager system users
        /// </summary>
        /// <returns></returns>
        public virtual ObjectResult<GetUsers_Result> GetUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUsers_Result>("GetUsers");
        }
    
        /// <summary>
        /// Grant a particular user role to a system user
        /// </summary>
        /// <param name="userName">User name of account to receive role</param>
        /// <param name="userRole">User role to add to account</param>
        /// <returns></returns>
        public virtual int GrantUserSDNRole(string userName, string userRole)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var userRoleParameter = userRole != null ?
                new ObjectParameter("userRole", userRole) :
                new ObjectParameter("userRole", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GrantUserSDNRole", userNameParameter, userRoleParameter);
        }
    
        /// <summary>
        /// Revoke a particular user role from a system user
        /// </summary>
        /// <param name="userName">User Account to revoke from role</param>
        /// <param name="userRole">Role to revoke</param>
        /// <returns></returns>
        public virtual int RevokeUserSDNRole(string userName, string userRole)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var userRoleParameter = userRole != null ?
                new ObjectParameter("userRole", userRole) :
                new ObjectParameter("userRole", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RevokeUserSDNRole", userNameParameter, userRoleParameter);
        }

    }
}
