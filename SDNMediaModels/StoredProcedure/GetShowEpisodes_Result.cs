using System;

namespace SDNMediaModels.StoredProcedure
{   
    
    public partial class GetShowEpisodes_Result
    {
        public int pk_EpisodeID { get; set; }
        public int fk_SeasonID { get; set; }
        public int fk_ShowID { get; set; }
        public int EpisodeNum { get; set; }
        public string EpisodePath { get; set; }
        public string EpisodePlayerPath { get; set; }
        public string EpisodeDisplayTitle { get; set; }
        public string EpisodeAlbumArtPath { get; set; }
        public int IsEnabled { get; set; }
        public Nullable<int> fk_MediaID { get; set; }
        public Nullable<int> fk_MediaType { get; set; }
    }
}
