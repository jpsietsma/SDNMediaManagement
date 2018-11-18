using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDNMediaModels.Api.YIFY
{
    public class YIFYRootModel
    {
        public string status { get; set; }
        public string status_message { get; set; }
        public YIFYData data { get; set; }
        public YIFYMeta meta { get; set; }
    }
}
