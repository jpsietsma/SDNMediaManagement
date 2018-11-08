using System;
using System.Collections.Generic;

namespace SDNMediaModels.List
{   
    
    public partial class list_TaskTypes
    {
        public int pk_TaskTypeID { get; set; }
        public string TaskTypeName { get; set; }
        public int fk_TaskPriority { get; set; }
    
        public virtual list_AutomationPriority list_AutomationPriority { get; set; }
    }
}
