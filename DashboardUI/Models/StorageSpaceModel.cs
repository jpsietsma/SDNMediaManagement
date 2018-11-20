using SDNMediaModels.List;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DashboardUI.Models
{
    public class StorageSpaceModel : list_MediaDrives
    {
        new public int pk_MediaDriveID { get; set; }

        [Display(Name = "Available Space")]
        new public double DriveFreeSpace { get; set; }

        [Display(Name = "Total Space")]
        new public double DriveCapacity { get; set; }

        [NotMapped]
        [Display(Name = "Used Space")]
        public double UsedSpace { get; set; }

        new public string DriveLetter { get; set; }

        new public int fk_MediaTypeID { get; set; }

        new public int? fk_MediaSubTypeID { get; set; }

        public StorageSpaceModel ConvertFromListMediaDrives(list_MediaDrives model)
        {
            var cvt = Double.TryParse(model.DriveFreeSpace, out double freeSpaceDouble);
            var cvt2 = Double.TryParse(model.DriveCapacity, out double capacityDouble);

            return new StorageSpaceModel{ DriveFreeSpace = freeSpaceDouble, DriveCapacity = capacityDouble, DriveLetter = model.DriveLetter, fk_MediaSubTypeID = model.fk_MediaSubTypeID, fk_MediaTypeID = model.fk_MediaTypeID, UsedSpace = (DriveCapacity - DriveFreeSpace)};
        }


        public StorageSpaceModel()
        {

        }
    }
}