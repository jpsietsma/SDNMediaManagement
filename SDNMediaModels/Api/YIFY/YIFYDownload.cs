using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDNMediaModels.Api.YIFY
{
    public class YIFYDownload
    {
        [Key]
        public int Id { get; set; }
        public string url { get; set; }
        public string hash { get; set; }
        public string quality { get; set; }
        public int seeds { get; set; }
        public int peers { get; set; }
        public string size { get; set; }
        public int size_bytes { get; set; }
        public string date_uploaded { get; set; }
        public int date_uploaded_unix { get; set; }
    }
}
