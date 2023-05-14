
using OpenQA.Selenium;

namespace CookieClicker_Automation
{
    public class BasePage  
    {
        public IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement AcceptAllButton => driver.FindElement(By.XPath("//*[@id='L2AGLb']/div"));
    }
}
