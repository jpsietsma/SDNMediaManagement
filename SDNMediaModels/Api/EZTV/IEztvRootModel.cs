using System.Collections.Generic;

namespace SDNMediaModels.Api.EZTV
{
    public interface IEztvRootModel
    {
        string imdb_id { get; set; }
        int limit { get; set; }
        int page { get; set; }
        List<EztvResult> torrents { get; set; }
        int torrents_count { get; set; }
    }
}