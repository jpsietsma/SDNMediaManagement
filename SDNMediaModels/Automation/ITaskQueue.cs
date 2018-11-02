using System;
using System.Collections.Generic;
using SDNMediaModels.Account;
using SDNMediaModels.List;

namespace SDNMediaModels.Feedback
{
    public interface ITaskQueue
    {
        AspNetUser AspNetUser { get; set; }
        int fk_ActionType { get; set; }
        int? fk_ParentTaskID { get; set; }
        string fk_TaskOwner { get; set; }
        int fk_TaskStatus { get; set; }
        list_AutomationActions list_AutomationActions { get; set; }
        list_AutomationStatuses list_AutomationStatuses { get; set; }
        int pk_TaskID { get; set; }
        string TaskDetails { get; set; }
        DateTime? TaskEndTime { get; set; }
        ICollection<TaskQueue> TaskQueue1 { get; set; }
        TaskQueue TaskQueue2 { get; set; }
        DateTime TaskStartTime { get; set; }
        string TaskTitle { get; set; }
    }
}