using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DashboardUI.Models;
using MediaMaintenanceLibrary;
using ConfigurationLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            Configuration config = new Configuration();

            SortMediaItemModel sortItem = new SortMediaItemModel();
            TelevisionEpisodeItem episode = sortItem.ToEpisode();


            //string sqlUser = 

            //string loginToken = TvdbApiLibrary.GetTvdbLoginToken();

            //Beginning:;
            //Console.Write("Enter Command: ");
            //string readline = Console.ReadLine();
            //while(readline == "go")
            //{
            //    Console.Clear();
            //    Console.WriteLine("login token: " + loginToken + ")");
            //    Console.WriteLine();
            //    Console.WriteLine("What Would you like to do? ");
            //    Console.WriteLine("[0] - Login");
            //    Console.WriteLine("[1] - Refresh Token");
            //    Console.WriteLine("[2] - Search All Shows");
            //    Console.WriteLine("[3] - Get Show Details");
            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        //executes POST command to Tvdb api login with our api credentials, returns JWT login token  as string
            //        case "0":
            //            {                          

            //                loginToken = TvdbApiLibrary.GetTvdbLoginToken();
            //                Console.WriteLine();

            //                break;
            //            }

            //        //login tokens are initially only good for 24 hours, executing a GET to refresh_data will extend our token life
            //        case "1":
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("Api Refresh token: " + TvdbApiLibrary.RefreshTvdbLoginToken(loginToken));
            //                Console.WriteLine();
            //                Console.ReadLine();
            //                break;
            //            }

            //        //executes a POST request to the /search/series route passing the name we searched for as the query string
            //        case "2":
            //            {
            //                Console.WriteLine("Show to search:");
            //                string query = Console.ReadLine();
            //                List<SeriesSearchResult> results = TvdbApiLibrary.SearchSeries(query, loginToken);
            //                Console.WriteLine();

            //                foreach (var item in results.Where(r => r.seriesName == query))
            //                {
            //                    Console.WriteLine(item);
            //                }
            //                Console.ReadLine();

            //                break;

            //            }
            //        case "3":
            //            {
            //                Console.WriteLine("Enter Show ID:");
            //                string response = Console.ReadLine();
            //                Console.WriteLine();
            //                Console.WriteLine();
            //                List<SeriesResult> seriesInfo = TvdbApiLibrary.SeriesInfo(response, loginToken);


            //                break;
            //            }

            //        case "exit":
            //            {
            //                goto Beginning;
            //            }

            //        default:
            //            {
            //                readline = "go";

            //                break;
            //            }
            //    }
            //}

        }
    }
}
