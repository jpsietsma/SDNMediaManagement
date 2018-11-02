using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using SDNMediaModels.Api;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MediaMaintenanceLibrary
{

    /// <summary>
    /// Provides access to query the Tvdb Api
    /// </summary>
    public static class TvdbApiLibrary
    {

        /// <summary>
        /// Post to url to get api token for requests
        /// </summary>
        /// <param name="url">URL to POST request to</param>
        /// <param name="ApiKey">Your Eztv API key</param>
        /// <param name="UserName">Your Eztv Username</param>
        /// <param name="UserKey">Your Eztv secret user key</param>
        /// <returns>string of authenticated login token</returns>
        /// <remarks>Token needs to be refreshed every 24 hours.</remarks>
        public static string GetTvdbLoginToken(string url = "https://api.thetvdb.com/login", string ApiKey = "0H0EDCYE0XE6GEYL", string UserName = "jpsietsma", string UserKey = "4550538EC5427D6C")
        {

            string finalToken;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {

                string json = "{" + "\"apikey\":\"" + ApiKey + "\"," + "\"username\":\"" + UserName + "\"," + "\"userkey\":\"" + UserKey + "\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    var response = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                    finalToken = response.Values.ElementAt(0);

                }
            }

            return finalToken;

        }

        /// <summary>
        /// Extend Life of our api token by 24 hours
        /// </summary>
        /// <param name="token">Token to refresh</param>
        /// <param name="url">Url to refresh token request</param>
        /// <returns>Refreshed token string</returns>
        public static string RefreshTvdbLoginToken(string token, string url = "https://api.thetvdb.com/refresh_token")
        {
            string finalToken = token;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            httpWebRequest.Method = "GET";
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add("Authorization", "Bearer " + token);

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                var response = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                finalToken = response.Values.ElementAt(0);

            }

            return finalToken;
        }

    }
}
