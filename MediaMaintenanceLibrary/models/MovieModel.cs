using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaMaintenanceLibrary.enums;
using MediaMaintenanceLibrary.interfaces;

namespace MediaMaintenanceLibrary.models
{
    public class MovieModel : IBaseMediaItem
    {
        public int pk_MovieID { get; set; }
        public string fileName { get; set; }
        public string filePath { get; set; }
        public MovieGenreOptions MovieGenre { get; set; } = MovieGenreOptions.UNSORTED;
        public MediaTypeOptions fileMediaType { get; set; } = MediaTypeOptions.MOVIE;

    }
}
