using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DashboardUI.Models
{
    public class EztvDownloadModel
    {
        public string DownloadUrl { get; set; }
        public string MagnetUrl { get; set; }
        public string ShowName { get; set; }
        public string ShowSeason { get; set; }
        public string ShowEpisode { get; set; }
        public string SanitizedFileName { get; set; }
        public string DownloadMethod { get; set; }
        public string FileName { get; set; }

    }
}