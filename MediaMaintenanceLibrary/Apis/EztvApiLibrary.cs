using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SDNMediaModels.Api;
using SDNMediaModels.Api.EZTV;
using SDNMediaModels.Television;

namespace MediaMaintenanceLibrary
{

    /// <summary>
    /// Provides access the Eztv API
    /// </summary>
    public static class EztvApiLibrary
    {

        /// <summary>
        /// Execute GET query to Eztv api to return daily downloads 
        /// </summary>
        /// <param name="url">API url to GET request</param>
        /// <param name="page"># Page of download results</param>
        /// <param name="pageResults"># of downloads per page</param>
        /// <returns></returns>
        public static List<EztvResult> GetEztvDownloads(string url = "https://eztv.ag/api/get-torrents", int page = 1, int pageResults = 100)
        {
            string finalData;
            List<EztvResult> finalList = new List<EztvResult>();

            url += $"?limit={ pageResults }&page={ page }";

            WebRequest wRequest = WebRequest.Create(url);
            WebResponse response = wRequest.GetResponse();
            Stream ds = response.GetResponseStream();

            using (StreamReader r = new StreamReader(ds))
            {
                finalData = r.ReadToEnd();
            }

            var root = JsonConvert.DeserializeObject<EztvRootModel>(finalData);

            foreach (EztvResult eztv in root.torrents)
            {
                finalList.Add(eztv);
            }

            return finalList;
        }
        
        /// <summary>
        /// Call Eztv API for Json array of episodes for show with Imdb ID set
        /// </summary>
        /// <param name="show">Television Show model representing show to query Eztv for episodes</param>
        /// <param name="minSeeds">string minimum number of seeds for episode to be included</param>
        /// <returns>List of EztvResult representing episodes available to download</returns>
        public static List<EztvResult> GetEztvEpisodes(this TelevisionShow show, string minSeeds = null)
        {
            string finalJson = string.Empty;
            List<EztvResult> finalList = new List<EztvResult>();


            if (!string.IsNullOrEmpty(show.ImdbID))
            {
                string baseUrl = $@"https://eztv.ag/api/get-torrents?imdb_id={ show.ImdbID }";

                if (minSeeds == null)
                {
                    WebRequest wRequest = WebRequest.Create(baseUrl);
                    WebResponse response = wRequest.GetResponse();
                    Stream ds = response.GetResponseStream();

                    using (StreamReader r = new StreamReader(ds))
                    {
                        finalJson = r.ReadToEnd();
                    }

                    var root = JsonConvert.DeserializeObject<EztvRootModel>(finalJson);

                    foreach (EztvResult eztv in root.torrents)
                    {
                        finalList.Add(eztv);
                    }

                }

                
            }                        

            return finalList;
        }

    }
}
