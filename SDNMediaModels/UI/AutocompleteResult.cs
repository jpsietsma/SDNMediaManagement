using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDNMediaModels.UI
{

    /// <summary>
    /// Class to handle show autocomplete results
    /// </summary>
    public class AutocompleteResult
    {

        /// <summary>
        /// Name of resulting show
        /// </summary>
        public string ShowName { get; set; }

        /// <summary>
        /// Number of seasons available for result show
        /// </summary>
        public string ShowNumSeasons { get; set; }

        /// <summary>
        /// Number of episodes availavle for result show
        /// </summary>
        public string ShowNumEpisodes { get; set; }

        /// <summary>
        /// Create autocomplete result from row in TelevisionShow table
        /// </summary>
        /// <param name="showName">Name of result show</param>
        /// <param name="numSeasons">Number of seasons for result</param>
        /// <param name="numEpisodes">Number of episodes for result</param>
        public AutocompleteResult(string showName, string numSeasons, string numEpisodes)
        {
            ShowName = showName;
            ShowNumSeasons = numSeasons;
            ShowNumEpisodes = numEpisodes;
        }

    }
}
