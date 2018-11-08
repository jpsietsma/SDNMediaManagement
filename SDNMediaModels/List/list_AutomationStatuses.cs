using SDNMediaModels.Feedback;
using SDNMediaModels.Sort;
using System;
using System.Collections.Generic;

namespace SDNMediaModels.List
{  
    
    public partial class list_AutomationStatuses
    {

        public list_AutomationStatuses()
        {
            this.ProcessQueues = new HashSet<ProcessQueue>();
            this.UserRequests = new HashSet<UserRequest>();
            this.TaskQueues = new HashSet<TaskQueue>();
            this.sortItems = new HashSet<sortItem>();
        }
    
        public int pk_automationStatus { get; set; }
        public string automationStatusDisplay { get; set; }
        public int automationNextAction { get; set; }
    
        public virtual ICollection<ProcessQueue> ProcessQueues { get; set; }
        public virtual ICollection<UserRequest> UserRequests { get; set; }
        public virtual ICollection<TaskQueue> TaskQueues { get; set; }
        public virtual ICollection<sortItem> sortItems { get; set; }
    }
}
