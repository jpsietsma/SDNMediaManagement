using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDNMediaModels.StoredProcedure
{    

    public partial class GetMovies_Result
    {

        public GetMovies_Result()
        {
            string[] path = this.FilePath.Split('\\');

            this.FileName = path[path.Length - 1];
        }

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
    }
}
