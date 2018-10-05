using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary
{
    public class SeriesSearchResult
    {
        public int id { get; set; }
        public string[] aliases { get; set; }
        public string banner { get; set; }
        public string firstAired { get; set; }
        public string network { get; set; }
        public string overview { get; set; }
        public string seriesName { get; set; }
        public string slug { get; set; }
        public string status { get; set; }
        public bool ExistingShow { get; set; }

        public SeriesSearchResult()
        {
            
        }

    }
}
