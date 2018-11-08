using System;

namespace SDNMediaModels.StoredProcedure
{    
    
    public partial class GetShowSeasons_Result
    {
        public int pk_SeasonID { get; set; }
        public int fk_ShowID { get; set; }
        public string SeasonName { get; set; }
        public string SeasonHomePath { get; set; }
        public int SeasonNumEpisodes { get; set; }
        public string SeasonAlbumArtPath { get; set; }
        public int IsEnabled { get; set; }
    }
}
