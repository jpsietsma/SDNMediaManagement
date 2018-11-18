using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDNMediaModels.UI
{
    public class AutocompleteResult
    {
        public string ShowName { get; set; }
        public string ShowNumSeasons { get; set; }
        public string ShowNumEpisodes { get; set; }

        public AutocompleteResult(string showName, string numSeasons, string numEpisodes)
        {
            ShowName = showName;
            ShowNumSeasons = numSeasons;
            ShowNumEpisodes = numEpisodes;
        }
    }
}
