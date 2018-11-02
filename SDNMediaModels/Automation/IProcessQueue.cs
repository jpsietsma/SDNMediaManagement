using System;
using System.Collections.Generic;
using SDNMediaModels.List;
using SDNMediaModels.Logs;

namespace SDNMediaModels.Feedback
{
    public interface IProcessQueue
    {
        ICollection<FileMoveHistory> FileMoveHistories { get; set; }
        int fk_AutomationPriority { get; set; }
        int fk_AutomationStatus { get; set; }
        int? fk_MediaID { get; set; }
        string fk_UserID { get; set; }
        list_AutomationPriority list_AutomationPriority { get; set; }
        list_AutomationStatuses list_AutomationStatuses { get; set; }
        int? NextAction { get; set; }
        int pk_ProcessID { get; set; }
        int ProcessAction { get; set; }
        DateTime RequestTimestamp { get; set; }
    }
}