
using OpenQA.Selenium;

namespace CookieClicker_Automation
{
    public class LandingPage : BasePage
    {
        public LandingPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement PageTitle => driver.FindElement(By.XPath("//h1[text()='Cookie Clicker!']"));
        public IWebElement NewGameSectionHeading => driver.FindElement(By.XPath("//h2[text()='New Game']"));
        public IWebElement StartButton => driver.FindElement(By.XPath("//button[text()='Start!']"));
        public IWebElement YourNameTextInputBox => driver.FindElement(By.XPath("/html/body/form/input"));
        public IWebElement HighScoresSectionHeading => driver.FindElement(By.XPath("//h2[text()='High Scores']"));
        public IWebElement PlayerTitle => driver.FindElement(By.XPath("//th[text()='Player']"));
        public IWebElement ScoreTitle => driver.FindElement(By.XPath("/html/body/table/thead/tr/th[2]"));

    }
}
