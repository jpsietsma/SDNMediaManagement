using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDNMediaModels.enums
{
    /// <summary>
    /// Selection of options for MovieGenre property of MovieModel object
    /// </summary>
    public enum MovieGenreOptions
    {
        /// <summary>
        /// Default: Item has not been given a genre
        /// </summary>
        UNSORTED,

        /// <summary>
        /// Indicates an Action Movie
        /// </summary>
        ACTION,

        /// <summary>
        /// Indicates a Comedy Movie
        /// </summary>
        COMEDY,

        /// <summary>
        /// Indicates a Romance Movie
        /// </summary>
        ROMANCE,

        /// <summary>
        /// Indicates a Thriller Movie
        /// </summary>
        THRILLER,

        /// <summary>
        /// Indicates a Horror Movie
        /// </summary>
        HORROR,

        /// <summary>
        /// Indicates a Family Movie
        /// </summary>
        FAMILY,

        /// <summary>
        /// Indicates a Children's Movie
        /// </summary>
        CHILDREN,

        /// <summary>
        /// Indicates an Animated Movie
        /// </summary>
        ANIMATED,

        /// <summary>
        /// Indicates a Musical Movie
        /// </summary>
        MUSICAL,

        /// <summary>
        /// Indicates a Mystery Movie
        /// </summary>
        MYSTERY,

        /// <summary>
        /// Indicates a Drama Movie
        /// </summary>
        DRAMA,

        /// <summary>
        /// Indicates a Documentary Movie
        /// </summary>
        DOCUMENTARY
    }
}
