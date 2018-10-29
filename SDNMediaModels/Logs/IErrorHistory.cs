using System;

namespace SDNMediaModels.Logs
{
    public interface IErrorHistory
    {
        string errorExceptionInner { get; set; }
        string errorExceptionMessage { get; set; }
        string errorMessage { get; set; }
        int errorThread { get; set; }
        DateTime errorTimestamp { get; set; }
        string errorType { get; set; }
        int pk_errorID { get; set; }
    }
}