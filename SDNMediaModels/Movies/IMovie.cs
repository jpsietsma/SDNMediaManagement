using SDNMediaModels.List;
using SDNMediaModels.Sort;

namespace SDNMediaModels.Movies
{
    public interface IMovie
    {
        string FileName { get; set; }
        string FilePath { get; set; }
        int? fk_MediaID { get; set; }
        int fk_MediaType { get; set; }
        int fk_MovieGenre { get; set; }
        string ImdbID { get; set; }
        list_MediaTypes list_MediaTypes { get; set; }
        list_MovieGenres list_MovieGenres { get; set; }
        string MovieTitle { get; set; }
        int? MovieYear { get; set; }
        int pk_MovieID { get; set; }
        sortItem sortItem { get; set; }
        int SubtitlesExist { get; set; }
        string TvdbID { get; set; }
    }
}