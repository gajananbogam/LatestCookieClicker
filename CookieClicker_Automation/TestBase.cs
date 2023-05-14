
using OpenQA.Selenium;
using System;
using System.Threading;

namespace CookieClicker_Automation
{
   public class TestBase : IDisposable
    {
        public IWebDriver driver;
        public BasePage basePage;
        public LandingPage landingPage;
        public StartPage startPage;

        public TestBase()
        {
            driver = DriverClass.CreateDriver();
            basePage = new BasePage(driver);
            landingPage = new LandingPage(driver);
            startPage = new StartPage(driver);
        }

        public void LaunchCoockieClickerApplication()
        {
            driver.Navigate().GoToUrl("https://gajanan-bogam-2023-04-25.cookieclickertechtest.airelogic.com/");
        }

        public void AcceptAllButton()
        {
            basePage.AcceptAllButton.Click();
        }

        public void StartTheGameByEnteringPlayerName()
        {
            landingPage.YourNameTextInputBox.SendKeys(Constants.Player1Name);
            landingPage.StartButton.Click();
        }

        public void CollectCookies(int noOfCookies)
        {
            for (int i = 1; i <= noOfCookies; i++)
            {
                startPage.ClickCookieButton.Click();
            }
        }

        public void SellCookies(string cookies)
        {
            startPage.SellCookiesInputBox.SendKeys(cookies);
            startPage.SellCookiesButton.Click();
        }

        public void BuyFactories(string noOfFactories )
        {
            startPage.BuyFactoriesInputBox.SendKeys(noOfFactories);
            startPage.BuyFactoriesButton.Click();
        }

        public void WaitForApplictionToLaodOrSync()
        {
            Thread.Sleep(4000);
        }

        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
