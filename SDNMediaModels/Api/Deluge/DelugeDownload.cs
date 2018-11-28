using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDNMediaModels.Api.Deluge
{
    /// <summary>
    /// Class representing Root json response from Deluge API
    /// </summary>
    public class DelugeDownloadRoot
    {

        /// <summary>
        /// request result id (not used)
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Results from request if successful
        /// </summary>
        public DelugeResult result { get; set; }

        /// <summary>
        /// Error from request if unsuccessful
        /// </summary>
        public object error { get; set; }

    }

    /// <summary>
    /// Class with list of torrents from request
    /// </summary>
    public class DelugeResult
    {
        /// <summary>
        /// Response result list of torrent(s)
        /// </summary>
        public List<DelugeDownload> torrents { get; set; }

    }

    /// <summary>
    /// Class representing a downloading from the deluge web api
    /// </summary>
    public class DelugeDownload
    {
        /// <summary>
        /// Comments associated with torrent download
        /// </summary>
        public string comment { get; set; }

        /// <summary>
        /// Hash associated with torrent download
        /// </summary>
        public string hash { get; set; }

        /// <summary>
        /// Name associated with torrent download
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Save path associated with torrent download
        /// </summary>
        public string save_path { get; set; }

    }

}
