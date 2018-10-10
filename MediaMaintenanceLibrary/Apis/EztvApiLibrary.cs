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
    public static class EztvApiLibrary
    {

        //executes GET command to Tvdb api to extend our token life
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
