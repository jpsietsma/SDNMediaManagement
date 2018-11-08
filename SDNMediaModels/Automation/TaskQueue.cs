using SDNMediaModels.Account;
using SDNMediaModels.List;
using System;
using System.Collections.Generic;
	
namespace SDNMediaModels.Feedback
{
       
    public partial class TaskQueue : ITaskQueue
    {

        public TaskQueue()
        {
            this.TaskQueue1 = new HashSet<TaskQueue>();
        }
    
        public int pk_TaskID { get; set; }
        public string TaskTitle { get; set; }
        public System.DateTime TaskStartTime { get; set; }
        public Nullable<System.DateTime> TaskEndTime { get; set; }
        public Nullable<int> fk_ParentTaskID { get; set; }
        public int fk_TaskStatus { get; set; }
        public string fk_TaskOwner { get; set; }
        public string TaskDetails { get; set; }
        public int fk_ActionType { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual list_AutomationActions list_AutomationActions { get; set; }
        public virtual list_AutomationStatuses list_AutomationStatuses { get; set; }
        public virtual ICollection<TaskQueue> TaskQueue1 { get; set; }
        public virtual TaskQueue TaskQueue2 { get; set; }
    }
}
