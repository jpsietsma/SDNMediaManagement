using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDNMediaModels.Api.EZTV
{
    public class EztvRootModel : IEztvRootModel
    {
        public string imdb_id { get; set; }
        public int torrents_count { get; set; }
        public int limit { get; set; }
        public int page { get; set; }
        public List<EztvResult> torrents { get; set; }
    }
}
