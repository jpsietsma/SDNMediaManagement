using SDNMediaModels.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDNMediaModels.Movie
{
    public class MovieModel : IMovieModel
    {
        public int pk_MovieID { get; set; }
        public string fileName { get; set; }
        public string filePath { get; set; }
        public MovieGenreOptions MovieGenre { get; set; } = MovieGenreOptions.UNSORTED;
        public MediaTypeOptions fileMediaType { get; set; } = MediaTypeOptions.MOVIE;

    }
}
