using SDNMediaModels.Feedback;
using System;
using System.Collections.Generic;

namespace SDNMediaModels.List
{   
    
    public partial class list_AutomationPriority
    {

        public list_AutomationPriority()
        {
            this.list_TaskTypes = new HashSet<list_TaskTypes>();
            this.ProcessQueues = new HashSet<ProcessQueue>();
        }
    
        public int pk_PriorityID { get; set; }
        public string PriorityDescription { get; set; }
        public int PriorityLevel { get; set; }
    
        public virtual ICollection<list_TaskTypes> list_TaskTypes { get; set; }
        public virtual ICollection<ProcessQueue> ProcessQueues { get; set; }
    }
}
