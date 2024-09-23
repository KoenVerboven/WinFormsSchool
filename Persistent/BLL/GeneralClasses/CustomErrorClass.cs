

namespace AppCode.BLL.GeneralClasses
{
    public class CustomErrorClass
    {
        public CustomErrorClass()
        {
            
        }

        public CustomErrorClass(string errorMessage, string username, string pageOrFormName,
                                string methodName, bool writeToLog, int? errorLineNumber,
                                DateTime errorOccurAtTime)
        {
            ErrorMessage = errorMessage;
            UserName = username;
            PageOrFormName = pageOrFormName;
            MethodName = methodName;
            WriteToLog = writeToLog;
            ErrorLineNumber = errorLineNumber;
            ErrorOccurAtTime = errorOccurAtTime;    
        }

        
        public string ErrorMessage { get; set; }
        public string? UserName { get; set; }
        public string PageOrFormName { get; set; }
        public string MethodName { get; set; }
        public bool? WriteToLog { get; set; }
        public int? ErrorLineNumber { get; set; }
        public DateTime ErrorOccurAtTime { get; set; }
    }
}
