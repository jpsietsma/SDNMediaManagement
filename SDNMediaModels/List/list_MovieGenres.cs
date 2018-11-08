using SDNMediaModels.Movies;
using System;
using System.Collections.Generic;

namespace SDNMediaModels.List
{   
    
    public partial class list_MovieGenres
    {

        public list_MovieGenres()
        {
            this.Movies = new HashSet<Movie>();
        }
    
        public int pk_GenreID { get; set; }
        public string GenreName { get; set; }
        public int GenreEnabled { get; set; }
        public string GenreHomePath { get; set; }
    
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
