using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FrameworkCore
{
    public class Browser : Driver
    {
        public IWebDriver? GenerateBrowserDriverBasedOnABrowserName(string browserName)
        {
            if (browserName == "Chrome")
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                WebDriver = new ChromeDriver();
            }
            else if (browserName == "Firefox")
            {
                new DriverManager().SetUpDriver(new FirefoxConfig());
                WebDriver = new FirefoxDriver();
            }

            WebDriver!.Manage().Window.Maximize();
            return WebDriver;
        }
    }
}