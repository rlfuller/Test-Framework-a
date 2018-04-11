using System.IO;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
//using System.Configuration.C//


public class Browsers
{
    private static IWebDriver _driver;
    //private static string baseURL = ConfigurationManager.AppSettings["url"];
    //private static string browser = ConfigurationManager.AppSettings["browser"];
    //private static string default_url = ConfigurationManage

    public static void Init(string browser)
    {

        switch(browser)
        {
            case "chrome":
                _driver = new ChromeDriver();
                break;
            case "firefox":
                _driver = new FirefoxDriver();
                break;
        }

    }
    public static IWebDriver driver
    {
        get { return _driver;}
    }
}