using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDNMediaModels.Api.YIFY
{
    public class YIFYMovieCast
    {
        
        public int Id { get; set; }[Key]

        public string name { get; set; }
        public string character_name { get; set; }
        public string url_small_image { get; set; }
        public string imdb_code { get; set; }
    }
}
