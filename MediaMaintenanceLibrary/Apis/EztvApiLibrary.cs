using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MediaMaintenanceLibrary
{

    /// <summary>
    /// Provides access  to query the Eztv API
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
        public static string GetDownloads(string url = "https://eztv.ag/api/get-torrents", int page = 1, int pageResults = 100)
        {
            string finalData;
            url += $"?limit={ pageResults }&page={ page }";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            httpWebRequest.Method = "GET";
            httpWebRequest.ContentType = "application/json";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                var response = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                finalData = response.Values.ElementAt(0);

            }

            return finalData;
        }

    }
}
