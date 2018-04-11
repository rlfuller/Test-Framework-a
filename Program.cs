using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;


namespace Selenium_TestFramework_1
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Hello World!");
    //     }
    // }

    [TestFixture]
    class AutomationCore 
    {
        IWebDriver driver;
        private IConfiguration Configuration {get; set;}

        [OneTimeSetUp]
        public void startTest()
        {
                
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            
            Configuration = builder.Build();
            //driver = new ChromeDriver();
            Browsers.Init(Configuration["browser"]);
            driver = Browsers.driver; 

            driver.Url = "http://www.google.com";
        }
        [OneTimeTearDown]
        public void endTest()
        {
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void testSomeWebsite()
        {
            Assert.IsTrue(driver.Title.Contains("Google"));
        }
    }
}
