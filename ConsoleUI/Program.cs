using System;
using MediaMaintenanceLibrary.models;
using MediaMaintenanceLibrary.enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MediaMaintenanceLibrary;

namespace ConsoleUI
{
    class Program
    {

        public static void Main(string[] args)
        {
            Beginning:
            Console.Clear();

            //ask for DL duration in minutes
            Console.WriteLine("Enter Duration in Minutes: ");
            string minutes = Console.ReadLine();

            //Ask for filesize in double xx.xx
            Console.WriteLine("Enter FileSize in MB (xx.xx): ");
            string fileSize = Console.ReadLine();

            //parse size and mins into double and int
            double.TryParse(fileSize, out double size);
            int.TryParse(minutes, out int mins);

            //Calculate download duration by minutes
            string finalDuration = Calculations.CalculateDownloadDuration(mins);
            Console.WriteLine("Download Took " + finalDuration + " to finish.");
            Console.WriteLine();
            
            //calculate Average Mb/s download speed with minutes and size
            Console.WriteLine(Calculations.CalculateMbpsAvg(mins, size));

            Console.ReadLine();
            goto Beginning;




            //SortMediaItemModel sortItem = new SortMediaItemModel { pk_MediaID = 1, fileName = "Test.Show.S01E01.mkv", filePath = @"S:\Test.Show.S01E01.mkv"};
            //TelevisionEpisodeModel episode = sortItem.ToEpisode();

            //Console.WriteLine(episode.EpisodePath);

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
