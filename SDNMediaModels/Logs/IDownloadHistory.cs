using System;

namespace SDNMediaModels.Logs
{
    public interface IDownloadHistory
    {
        DateTime? fileCompleted { get; set; }
        DateTime? fileCreated { get; set; }
        string fileMediaType { get; set; }
        string fileName { get; set; }
        string filePath { get; set; }
        int pendingSortProcessing { get; set; }
        int pk_downloadID { get; set; }
    }
}