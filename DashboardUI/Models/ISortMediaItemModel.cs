using System;

namespace DashboardUI.Models
{
    public interface ISortMediaItemModel
    {
        int pk_MediaID { get; set; }
        string fileName { get; set; }
        string filePath { get; set; }
        int hasBeenProcessed { get; set; }
        string fileNameSanitized { get; set; }
        int fk_fileMediaTypeID { get; set; }
        DateTime fileAdded { get; set; }
        DateTime fileModified { get; set; }

    }
}