using SDNMediaModels.Movie;
using SDNMediaModels.Sort;
using SDNMediaModels.Television;
using System;
using System.Collections.Generic;

namespace SDNMediaModels.List
{   
    
    public partial class list_MediaTypes
    {
        public list_MediaTypes()
        {
            this.Movies = new HashSet<Movie>();
            this.TelevisionEpisodes = new HashSet<TelevisionEpisode>();
            this.sortItems = new HashSet<sortItem>();
        }

        public int pk_MediaTypeID { get; set; }
        public string mediaTypeName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<TelevisionEpisode> TelevisionEpisodes { get; set; }
        public virtual ICollection<sortItem> sortItems { get; set; }
        public virtual list_MediaDrives list_MediaDrives { get; set; }
    }
}
