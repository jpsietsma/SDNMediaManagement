
using System.ComponentModel.DataAnnotations;

namespace SDNMediaModels.Api
{
    public class EztvResult : IEztvResult
    {
        public int id { get; set; }
        public string hash { get; set; }
        public string filename { get; set; }
        public string episode_url { get; set; }
        public string torrent_url { get; set; }
        public string magnet_url { get; set; }

        [Display(Name = "Download Title")]
        public string title { get; set; }

        [Display(Name = "IMDB ID")]
        public string imdb_id { get; set; }

        [Display(Name = "Show Season")]
        public string season { get; set; }

        [Display(Name = "Show Episode")]
        public string episode { get; set; }
        public string small_screenshot { get; set; }
        public string large_screenshot { get; set; }

        [Display(Name = "Download Seeds")]
        public int seeds { get; set; }
        public int peers { get; set; }

        [Display(Name = "Upload Date")]
        public int date_released_unix { get; set; }

        [Display(Name = "File Size")]
        public string size_bytes { get; set; }

        public EztvResult()
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