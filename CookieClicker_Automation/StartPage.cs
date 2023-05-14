
using OpenQA.Selenium;

namespace CookieClicker_Automation
{
   public class StartPage : BasePage
   {
        public StartPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement WelcomeMessage => driver.FindElement(By.XPath("/html/body/p[1]"));
        public IWebElement Cookies => driver.FindElement(By.Id("cookies"));
        public IWebElement Factories => driver.FindElement(By.Id("factories"));
        public IWebElement Money => driver.FindElement(By.Id("money"));
        public IWebElement ClickCookieButton => driver.FindElement(By.Id("click"));
        public IWebElement SellCookiesInputBox => driver.FindElement(By.Id("cookies-to-sell"));
        public IWebElement SellCookiesButton => driver.FindElement(By.Id("sell-cookies"));
        public IWebElement BuyFactoriesInputBox => driver.FindElement(By.Id("factories-to-buy"));
        public IWebElement BuyFactoriesButton => driver.FindElement(By.Id("buy-factories"));

    }
}
