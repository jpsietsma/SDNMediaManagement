using System;

namespace SDNMediaModels.EventLog
{
    public interface IEventLogModel
    {
        DateTime EventTime { get; set; }
        string EventType { get; set; }
        int pk_EventID { get; set; }
    }
}