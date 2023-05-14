using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace CookieClicker_Automation
{
    public static class DriverClass
    {
        public static IWebDriver driver;

        public static IWebDriver CreateDriver()
        {
            string Browser = Constants.Browser;
            if (Browser == "Windows Chrome")
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("no-sandbox");
                driver = new ChromeDriver(chromeOptions);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Manage().Window.Maximize();
                return driver;
            }
            else
            {
                var firefoxOptions = new FirefoxOptions();
                firefoxOptions.SetPreference("signon.rememberSignons", false);
                driver = new FirefoxDriver(firefoxOptions);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Manage().Window.Maximize();
                return driver;
            }
        }
    }
}
