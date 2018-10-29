using SDNMediaModels.enums;
using System.Data.Entity;

namespace SDNMediaModels.Television
{
    public interface ITelevisionShowModel
    {
        int IsEnabled { get; set; }
        int pk_ShowID { get; set; }
        DbSet<ITelevisionShowModel> sdnTelevisionShows { get; set; }
        string ShowDriveLetter { get; set; }
        string ShowHomePath { get; set; }
        string ShowName { get; set; }
        int ShowNumEpisodes { get; set; }
        int ShowNumSeasons { get; set; }

    }
}