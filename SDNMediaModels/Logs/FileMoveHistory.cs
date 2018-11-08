

namespace SDNMediaModels.Logs
{
    using SDNMediaModels.Feedback;
    using SDNMediaModels.Sort;
    using System;
    using System.Collections.Generic;
    
    public partial class FileMoveHistory : IFileMoveHistory
    {
        public int pk_moveID { get; set; }
        public string MoveSource { get; set; }
        public string MoveDestination { get; set; }
        public int fk_MediaID { get; set; }
        public System.DateTime MoveTime { get; set; }
        public Nullable<int> fk_ProcessID { get; set; }
    
        public virtual sortItem sortItem { get; set; }
        public virtual ProcessQueue ProcessQueue { get; set; }
    }
}
