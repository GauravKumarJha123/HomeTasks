using System.Configuration;

namespace UtilityClassLib.Utilities.Selenium
{
    public class Navigation
    {
        public static string baseUrl = ConfigurationManager.AppSettings["basePageUrl"];
        public static string inventoryUrl = ConfigurationManager.AppSettings["inventoryPageUrl"];
        public static string checkoutUrl = ConfigurationManager.AppSettings["checkoutPageUrl"];
        public static string finshPageUrl = ConfigurationManager.AppSettings["finishPageUrl"];
        public static string cartPageUrl = ConfigurationManager.AppSettings["cartPageUrl"];
        //public static string extentReportPath = ConfigurationManager.AppSettings["extentReportFilePath"];

        
        public static string highlightedColour = "arguments[0].style.border='5px solid green'";
    }
}
