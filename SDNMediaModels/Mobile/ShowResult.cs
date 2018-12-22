using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDNMediaModels.Mobile
{
    /// <summary>
    /// View Model class to display show results on mobile platforms
    /// </summary>
    public class MobileShowResult
    {
        [Display(Name = "Show Name")]
        public string ShowName { get; set; }

        [Display(Name = "Number of Seasons")]
        public int NumSeasons { get; set; }

        [Display(Name = "Number of Episodes")]
        public int NumEpisodes { get; set; }

    }
}
