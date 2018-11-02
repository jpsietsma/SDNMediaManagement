using System;
using SDNMediaModels.Feedback;
using SDNMediaModels.Sort;

namespace SDNMediaModels.Logs
{
    public interface IFileMoveHistory
    {
        int fk_MediaID { get; set; }
        int? fk_ProcessID { get; set; }
        string MoveDestination { get; set; }
        string MoveSource { get; set; }
        DateTime MoveTime { get; set; }
        int pk_moveID { get; set; }
        ProcessQueue ProcessQueue { get; set; }
        sortItem sortItem { get; set; }
    }
}