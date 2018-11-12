using System;
using System.Collections.Generic;

namespace SDNMediaModels.List
{

    public partial class list_MediaSubTypes
    {

        public list_MediaSubTypes()
        {
            this.list_MediaDrives = new HashSet<list_MediaDrives>();
        }

        public int pk_MediaSubTypeID { get; set; }
        public string MediaSubType { get; set; }

        public virtual ICollection<list_MediaDrives> list_MediaDrives { get; set; }
    }
}