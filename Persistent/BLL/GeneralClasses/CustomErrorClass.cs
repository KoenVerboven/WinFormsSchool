

namespace AppCode.BLL.GeneralClasses
{
    public class CustomErrorClass(string errorMessage, string username, string pageOrFormName,
                            string methodName, bool writeToLog, int? errorLineNumber,
                            DateTime errorOccurAtTime)
    {
        public string ErrorMessage { get; set; } = errorMessage;
        public string? UserName { get; set; } = username;
        public string PageOrFormName { get; set; } = pageOrFormName;
        public string MethodName { get; set; } = methodName;
        public bool? WriteToLog { get; set; } = writeToLog;
        public int? ErrorLineNumber { get; set; } = errorLineNumber;
        public DateTime ErrorOccurAtTime { get; set; } = errorOccurAtTime;
    }
}
