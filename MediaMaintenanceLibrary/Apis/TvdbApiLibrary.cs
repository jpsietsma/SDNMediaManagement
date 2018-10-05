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
    public static class TvdbApiLibrary
    {

        #region SDN TVDB API Authentication...

        // Executes POST command to url with provided apikey, username, and userkey.  It is important to note that login tokens are initially
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

        //executes GET command to Tvdb api to extend our token life
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

        #endregion

        #region SDN TVDB API Series-related....
        // Executes POST command to get a list of series that match our query
        public static List<SeriesSearchResult> SearchSeries(string queryShowName, string token, string returnField = "id")
        {

            string seriesFinal;
            List<SeriesSearchResult> finalResults = new List<SeriesSearchResult>();

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.thetvdb.com/search/series?name=" + queryShowName);

                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Headers.Add("Authorization", "Bearer " + token);

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    seriesFinal = result;

                }

            var resultObjects = AllChildren(JObject.Parse(seriesFinal))
                            .First(c => c.Type == JTokenType.Array && c.Path.Contains("data"))
                            .Children<JObject>();

            foreach (JObject result in resultObjects)
            {
                foreach (JProperty property in result.Properties())
                {
                    // do something with the property belonging to result
                }
            }


            // recursively yield all children of json
            IEnumerable<JToken> AllChildren(JToken json)
            {
                foreach (var c in json.Children())
                {
                    yield return c;
                    foreach (var cc in AllChildren(c))
                    {
                        yield return cc;
                    }
                }

            }

            foreach (var item in resultObjects)
            {
                finalResults.Add(item.ToObject<SeriesSearchResult>());
            }

            return finalResults;

        }

        public static List<SeriesResult> SeriesInfo (string id, string token)
        {
            string final;
            List<SeriesResult> finalDetails = new List<SeriesResult>();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.thetvdb.com/search/series/" + id);

            httpWebRequest.Method = "GET";
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add("Authorization", "Bearer " + token);

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                final = result;

            }

            var resultObjects = AllChildren(JObject.Parse(final))
                            .First(c => c.Type == JTokenType.Array && c.Path.Contains("data"))
                            .Children<JObject>();

            foreach (JObject result in resultObjects)
            {
                foreach (JProperty property in result.Properties())
                {
                    // do something with the property belonging to result
                }
            }


            // recursively yield all children of json
            IEnumerable<JToken> AllChildren(JToken json)
            {
                foreach (var c in json.Children())
                {
                    yield return c;
                    foreach (var cc in AllChildren(c))
                    {
                        yield return cc;
                    }
                }

            }

            foreach (var item in resultObjects)
            {
                finalDetails.Add(item.ToObject<SeriesResult>());
            }

            return finalDetails;
        }


        #endregion

        #region SDN TVDB API Episode-related...

        //code functions for episode related requests go here...

        #endregion

    }
}
