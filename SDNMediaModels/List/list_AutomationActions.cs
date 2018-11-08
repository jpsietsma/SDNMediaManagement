using SDNMediaModels.Feedback;
using System;
using System.Collections.Generic;

namespace SDNMediaModels.List
{   
    
    public partial class list_AutomationActions
    {

        public list_AutomationActions()
        {
            this.TaskQueues = new HashSet<TaskQueue>();
        }
    
        public int pk_ActionType { get; set; }
        public string ActionDescription { get; set; }
        public int fk_PriorityID { get; set; }
    
        public virtual ICollection<TaskQueue> TaskQueues { get; set; }
    }
}
