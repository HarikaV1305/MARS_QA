using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://localhost:5000";
        // ScreenShotPath
        // public static string ScreenshotPath = "C:\\Users\\OEM\Desktop\\MVP studio\\screenshort";
        public static string ScreenshotPath = getCodeDirectory() + @"\TestReports\Screenshots";
        //ExtentReportsPath
      // public static string ReportsPath = "c:\\Reports\\Report.html";
        public static string ReportsPath = getCodeDirectory() + @"\TestReports\Report.html";
        //ReportXML Path
        //publi static string ReportXMLPath = "C:\\Users\\OEM\Desktop\\MVP studio\\Repo\\XML"
        public static string ReportXMLPath = getCodeDirectory() + @"\TestReports\XML";
            public static string getCodeDirectory()
            {
                var filepath = System.AppDomain.CurrentDomain.BaseDirectory;
                return filepath + @"..\..\";
            }
    }
}
