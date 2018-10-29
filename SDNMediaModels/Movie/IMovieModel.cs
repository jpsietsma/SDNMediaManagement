using SDNMediaModels.enums;

namespace SDNMediaModels.Movie
{
    public interface IMovieModel
    {
        MediaTypeOptions fileMediaType { get; set; }
        string fileName { get; set; }
        string filePath { get; set; }
        MovieGenreOptions MovieGenre { get; set; }
        int pk_MovieID { get; set; }
    }
}