using System.Configuration;

namespace UtilityClassLib.Utilities.Selenium
{
    public class Navigation
    {
        public static string baseUrl = GetValueAppConfig("basePageUrl");
        public static string inventoryUrl = GetValueAppConfig("inventoryPageUrl");
        public static string checkoutUrl = GetValueAppConfig("checkoutPageUrl");
        public static string finshPageUrl = GetValueAppConfig("finishPageUrl");
        public static string cartPageUrl = GetValueAppConfig("cartPageUrl");
        //public static string extentReportPath = ConfigurationManager.AppSettings["extentReportFilePath"];

        public static string highlightedColour = "arguments[0].style.border='5px solid green'";

        public static string GetValueAppConfig(string key) => ConfigurationManager.AppSettings[key];

    }
}
