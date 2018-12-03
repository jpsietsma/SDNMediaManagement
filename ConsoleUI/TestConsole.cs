using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SDNMediaModels.DBContext;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using SDNMediaModels.Television;
using SDNMediaModels.Api;
using System.Net;
using MediaMaintenanceLibrary;

namespace ConsoleUI
{
    public class TestConsole
    {
        
        public static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    Console.WriteLine("Drive: " + drive.Name);
                    Console.WriteLine("Total Space: " + drive.TotalSize);
                    Console.WriteLine("Free Space: " + drive.AvailableFreeSpace);
                    Console.WriteLine();
                }               

            }

            Console.ReadLine();

            //bool DropTorrentFile()
            //{
            //    bool finalStatus()
            //    {

            //    }

            //    using (var client = new WebClient())
            //    {
            //        client.DownloadFile(urToFile, fileSavePath);
            //    }

            //}


            //List<EztvResult> downloads = EztvApiLibrary.GetEztvDownloads(pageResults: 100);

            //foreach (EztvResult eztv in downloads)
            //{
            //    Console.WriteLine("Title: " + eztv.title);
            //    Console.WriteLine("Season: " + eztv.season);
            //    Console.WriteLine("Episode " + eztv.episode);
            //    Console.WriteLine("Seeds: " + eztv.seeds);
            //    Console.WriteLine("Download Url: " + eztv.torrent_url);
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //TelevisionShow testShow = new TelevisionShow { ImdbID = "0096563"};

            //List<EztvResult> episodes = testShow.GetEztvEpisodes();

            //foreach (EztvResult eztv in episodes)
            //{
            //    Console.WriteLine("Title: " + eztv.title);
            //    Console.WriteLine("Season: " + eztv.season);
            //    Console.WriteLine("Episode: " + eztv.episode);
            //    Console.WriteLine("Seeds: " + eztv.seeds);
            //    Console.WriteLine("Download: " + eztv.torrent_url);
            //    Console.WriteLine("Exists on server? " + eztv.EpisodeExists());
            //    Console.WriteLine();
            //}

            Console.ReadLine();


            
        }

        

        //Console.WriteLine(MediaConversion.GetJsonArrayImageSrc(Directory.GetFiles(@"D:\xampp\htdocs\gamescreens\minecraft", "*", SearchOption.TopDirectoryOnly), @"minecraft"));
        //Console.ReadLine();    


        //List<string> files = new List<string>();
        //List<string> folders = new List<string>();

        //foreach (string folderPath in Directory.GetDirectories(@"D:\xampp\htdocs\gamescreens"))
        //{
        //    if (!folderPath.Contains("css") && !folderPath.Contains("dist") && !folderPath.Contains("third.party"))
        //    {
        //        folders.Add(folderPath);

        //        foreach (string file in (Directory.GetFiles(folderPath)))
        //        {
        //            files.Add(file);
        //        }

        //        Console.WriteLine(MediaConversion.GetJsonArrayImageSrc(files, folderPath)); 
        //    }

        //}

        //Console.ReadLine();

        //List<string> shows = new List<string>();
        //List<string> showUrls = new List<string>();

        //shows.Add(@"E:\TV Shows\Cops\Season 1\Cops.S01E01.mkv");
        //shows.Add(@"E:\TV Shows\Cops\Season 1\Cops.S01E07.mkv");
        //shows.Add(@"G:\TV Shows\Cops\Season 1\Archer.S01E02.mkv");
        //shows.Add(@"G:\TV Shows\Cops\Season 1\Archer.S01E03.mkv");
        //shows.Add(@"G:\TV Shows\Cops\Season 2\Breaking.Bad.S02E02.mkv");
        //shows.Add(@"G:\TV Shows\Cops\Season 1\Breaking.Bad.S01E07.mkv");

        //Console.WriteLine("Show Episodes:");
        //Console.WriteLine("-------------");

        //foreach (string item in shows)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine();
        //Console.WriteLine();
        //Console.WriteLine("Media Player Paths:");
        //Console.WriteLine("---------------------");

        //showUrls = MediaProcessingLibrary.BuildMediaStreamingUrl(shows);

        //foreach (string item in showUrls)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.ReadLine();





        //Beginning:
        //Console.Clear();

        ////ask for DL duration in minutes
        //Console.WriteLine("Enter Duration in Minutes: ");
        //string minutes = Console.ReadLine();

        ////Ask for filesize in double xx.xx
        //Console.WriteLine("Enter FileSize in MB (xx.xx): ");
        //string fileSize = Console.ReadLine();

        ////parse size and mins into double and int
        //double.TryParse(fileSize, out double size);
        //int.TryParse(minutes, out int mins);

        ////Calculate download duration by minutes
        //string finalDuration = Calculations.CalculateDownloadDuration(mins);
        //Console.WriteLine("Download Took " + finalDuration + " to finish.");
        //Console.WriteLine();

        ////calculate Average Mb/s download speed with minutes and size
        //Console.WriteLine(Calculations.CalculateMbpsAvg(mins, size));

        //Console.ReadLine();
        //goto Beginning;








        //sortItem sortItem = new sortItem { pk_MediaID = 1, fileName = "Test.Show.S01E01.mkv", filePath = @"S:\Test.Show.S01E01.mkv"};
        //TelevisionEpisode episode = sortItem.ToEpisode();

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
