using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDNMediaModels.enums
{
        /// <summary>
        /// The available types of media options the automation can process
        /// </summary>
        public enum MediaTypeOptions
        {
            /// <summary>
            /// Type of: Unprocessed file that has been downoaded
            /// </summary>
            SORT_ITEM = 1,

            /// <summary>
            /// Type of: Television Episode belonging to a series and a season, finalized
            /// </summary>
            TV_EPISODE,

            /// <summary>
            /// Type of: Movie item, finalized
            /// </summary>
            Movie,

            /// <summary>
            /// Type of: Software, program, etc.
            /// </summary>
            SOFTWARE,

            /// <summary>
            /// Type of: PC game or Emulators/Roms
            /// </summary>
            GAME,

            /// <summary>
            /// Type of: Other - includes everything else (Documents, pictures, subtitles, etc.)
            /// </summary>
            OTHER = 99
        }

}
