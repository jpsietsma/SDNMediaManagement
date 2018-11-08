using SDNMediaModels.List;
using SDNMediaModels.Logs;
using System;
using System.Collections.Generic;

namespace SDNMediaModels.Feedback
{
       
    public partial class ProcessQueue : IProcessQueue
    {

        public ProcessQueue()
        {
            this.FileMoveHistories = new HashSet<FileMoveHistory>();
        }
    
        public int pk_ProcessID { get; set; }
        public System.DateTime RequestTimestamp { get; set; }
        public int ProcessAction { get; set; }
        public int fk_AutomationPriority { get; set; }
        public int fk_AutomationStatus { get; set; }
        public string fk_UserID { get; set; }
        public Nullable<int> fk_MediaID { get; set; }
        public Nullable<int> NextAction { get; set; }
    
        public virtual ICollection<FileMoveHistory> FileMoveHistories { get; set; }
        public virtual list_AutomationPriority list_AutomationPriority { get; set; }
        public virtual list_AutomationStatuses list_AutomationStatuses { get; set; }
    }
}
