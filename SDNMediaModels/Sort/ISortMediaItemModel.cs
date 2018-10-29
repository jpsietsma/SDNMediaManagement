using System;
using SDNMediaModels.enums;

namespace SDNMediaModels.Sort
{
    public interface ISortMediaItemModel
    {
        DateTime fileAdded { get; set; }
        MediaTypeOptions fileMediaType { get; set; }
        DateTime fileModified { get; set; }
        string fileName { get; set; }
        string fileNameSanitized { get; set; }
        string filePath { get; set; }
        int fk_fileMediaTypeID { get; set; }
        int hasBeenProcessed { get; set; }
        int hasBeenSanitized { get; set; }
        int pk_MediaID { get; set; }

        string PopulateFileName(string filePath);
    }
}