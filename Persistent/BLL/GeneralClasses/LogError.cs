
namespace AppCode.BLL.GeneralClasses
{
    public class LogError
    {

        public void LogException(Exception oEx, string userName,
                                        string PageOrFormName, string methodName,
                                        string moreInfo, DateTime dateTime)
        {
            string[] lines =
            { "Date :" + dateTime,
              "UserName :" + userName,
              "Exception :" + oEx.Message,
              "FormName :" + PageOrFormName,
              "Methodname :" + methodName,
              "MoreInfo :" + moreInfo,
              "   "
            };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using StreamWriter outputFile = new(Path.Combine(docPath, "WinFormsSchoolErrorLog.txt"), true);
            foreach (string line in lines)
                outputFile.WriteLine(line);
        }
    }
}
