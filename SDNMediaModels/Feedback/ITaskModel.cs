using System;

namespace SDNMediaModels.Feedback
{
    public interface ITaskModel
    {
        int fk_ParentTaskID { get; set; }
        int fk_TaskOwner { get; set; }
        int fk_TaskPriority { get; set; }
        int fk_TaskStatus { get; set; }
        int fk_TaskType { get; set; }
        int pk_TaskID { get; set; }
        string TaskDetails { get; set; }
        DateTime TaskEndTime { get; set; }
        DateTime TaskStartTime { get; set; }
        string TaskTitle { get; set; }
    }
}