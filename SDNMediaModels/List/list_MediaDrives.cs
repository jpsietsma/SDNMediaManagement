using System;
using System.Collections.Generic;

namespace SDNMediaModels.List
{    

    public partial class list_MediaDrives
    {
        public int pk_MediaDriveID { get; set; }
        public string DriveLetter { get; set; }
        public int fk_MediaTypeID { get; set; }
        public string DriveSpace { get; set; }

        public virtual list_MediaTypes list_MediaTypes { get; set; }
    }
}
