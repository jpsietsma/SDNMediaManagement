using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDNMediaModels.Api.YIFY
{
    public class YIFYMeta
    {
        public int server_time { get; set; }
        public string server_timezone { get; set; }
        public int api_version { get; set; }
        public string execution_time { get; set; }
    }
}
