using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDNMediaModels.List
{    

    public partial class list_MediaDrives
    {
        public list_MediaDrives()
        {

        }

        public int pk_MediaDriveID { get; set; }
        public string DriveLetter { get; set; }
        public int fk_MediaTypeID { get; set; }
        public Nullable<int> fk_MediaSubTypeID { get; set; }
        public string DriveFreeSpace { get; set; }
        public string DriveCapacity { get; set; }
        public virtual list_MediaSubTypes list_MediaSubTypes { get; set; }
        public virtual list_MediaTypes list_MediaTypes { get; set; }

        /// <summary>
        /// Convert property DriveFreeSpace
        /// </summary>
        /// <returns>value of DriveFreeSpace as double on success or 0 if unscanned</returns>
        public double GetDriveCapacity()
        {
            double finalDriveCapacity;

            if (this.DriveFreeSpace != "unscanned")
            {
                double.TryParse(this.DriveFreeSpace, out finalDriveCapacity);
            }
            else
            {
                finalDriveCapacity = 0;
            }

            return finalDriveCapacity;
        }

        /// <summary>
        /// Convert property of DriveCapacity
        /// </summary>
        /// <returns>value of DriveCapacity as double on success or 0 if unscanned</returns>
        public double GetFreeSpace()
        {
            double finalFreeSpace;

            if (this.DriveFreeSpace != "unscanned")
            {
                double.TryParse(this.DriveFreeSpace, out finalFreeSpace);
            }
            else
            {
                finalFreeSpace = 0;
            }

            return finalFreeSpace;
        }

    }
}
