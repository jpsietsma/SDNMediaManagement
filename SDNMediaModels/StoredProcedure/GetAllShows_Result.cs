using System;

namespace SDNMediaModels.StoredProcedure
{   
    
    public partial class GetAllShows_Result
    {
        public int pk_ShowID { get; set; }
        public string ShowName { get; set; }
        public string ShowDriveLetter { get; set; }
        public string ShowHomePath { get; set; }
        public int ShowNumSeasons { get; set; }
        public int ShowNumEpisodes { get; set; }
        public string ShowAlbumArtPath { get; set; }
        public int IsEnabled { get; set; }
        public string TvdbID { get; set; }
        public string ImdbID { get; set; }
        public Nullable<int> fk_MediaType { get; set; }
    }
}
