using SDNMediaModels.List;
using SDNMediaModels.Sort;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDNMediaModels.Movies
{   

    public partial class Movie : IMovie
    {
        public int pk_MovieID { get; set; }
        public string MovieTitle { get; set; }
        public Nullable<int> MovieYear { get; set; }
        public int fk_MovieGenre { get; set; }
        public string FilePath { get; set; }

        [NotMapped]
        public string FileName { get; set; }
        public string ImdbID { get; set; }
        public string TvdbID { get; set; }
        public int SubtitlesExist { get; set; }
        public Nullable<int> fk_MediaID { get; set; }
        public int fk_MediaType { get; set; }
    
        public virtual list_MediaTypes list_MediaTypes { get; set; }
        public virtual list_MovieGenres list_MovieGenres { get; set; }
        public virtual sortItem sortItem { get; set; }
    }
}
