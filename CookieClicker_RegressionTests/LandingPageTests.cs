
using CookieClicker_Automation;
using FluentAssertions;
using Xunit;

namespace CookieClicker_RegressionTests
   
{
    [Collection("Sequential")]
    public class LandingPageTests : TestBase
    {
        public LandingPageTests()
        {
            LaunchCoockieClickerApplication();
        }

        [Fact]
        public void VerifyTextOfCookieClickerLandingPage()
        {
            landingPage.PageTitle.Text.Should().Be(Constants.CookieClickerTitle);
            landingPage.NewGameSectionHeading.Text.Should().Be(Constants.NewGameSectionTitle);
            landingPage.HighScoresSectionHeading.Text.Should().Be(Constants.HighScoresSectioTitle);
        }

        [Fact]
        public void VerifyNewGameSectionAtLandingPage()
        {
            landingPage.StartButton.Displayed.Should().BeTrue();
            landingPage.YourNameTextInputBox.Displayed.Should().BeTrue();
        }

        [Fact]
        public void VerifyHighScoresSection()
        {
            landingPage.HighScoresSectionHeading.Text.Should().Be(Constants.HighScoresSectioTitle);
            landingPage.PlayerTitle.Text.Should().Be(Constants.PlayerSubSectionTitle);
            landingPage.ScoreTitle.Text.Should().Be(Constants.ScoresSubSectionTitle);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" Airelogic QA Team")]
        [InlineData(" @@@@@@@")]
        [InlineData(" I am entering the string which is very long, ideally this long string should not be allowed at the name field")]
        public void VerifyYourNameTextboxFunctionality(string name)
        {
            landingPage.YourNameTextInputBox.SendKeys(name);
            landingPage.StartButton.Click();
            startPage.WelcomeMessage.Text.Should().Be(Constants.WelcomeMessage + name);
        }
    }
}
