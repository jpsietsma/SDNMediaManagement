
namespace SDNMediaModels.Api
{
    public class EztvResultModel : IEztvResultModel
    {
        public int EztvID { get; set; }
        public string Hash { get; set; }
        public string FileName { get; set; }
        public string EpisodeUrl { get; set; }
        public string TorrentUrl { get; set; }
        public string MagnetUrl { get; set; }
        public string Title { get; set; }
        public int ImdbId { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }
        public string SmallScreenshot { get; set; }
        public string LargeScreenshot { get; set; }
        public int Seeds { get; set; }
        public int Peers { get; set; }
        public int ReleaseDateEpoc { get; set; }
        public int SizeBytes { get; set; }

        public EztvResultModel()
        {

        }

        public bool ShowExists()
        {
            bool finalExists = false;

            //Run logic to see if show exists

            return finalExists;
        }

        public bool EpisodeExists()
        {
            bool finalExists = false;

            //Run logic to see if episode already exists

            return finalExists;
        }

        public bool DownloadExists()
        {
            bool finalExists = false;

            //Run logic to see if file exists in sort folder

            return finalExists;
        }
        
    }
}