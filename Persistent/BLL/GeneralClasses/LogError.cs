
using System.Collections.Generic;

namespace AppCode.BLL.GeneralClasses
{
    public class LogError
    {

        public static void LogException(Exception oEx, Dictionary<string,string> errorData)
        {
            List<string> lines =
            [
                $"Date               : {DateTime.Now.ToLongDateString()}  {DateTime.Now.ToLongTimeString()}",
                $"Exception          : {oEx.Message}",
            ];

            foreach (var key in errorData.ToArray())
            {
                lines.Add(key.Key + " = " + key.Value);
            }
            lines.Add("--------------------------------------------");

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using StreamWriter outputFile = new(Path.Combine(docPath, "WinFormsSchoolErrorLog.txt"), true);
            foreach (string line in lines)
                outputFile.WriteLine(line);
        }
    }
}
