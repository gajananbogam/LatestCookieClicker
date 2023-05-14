
using CookieClicker_Automation;
using FluentAssertions;
using Xunit;

namespace CookieClicker_RegressionTests
{
    [Collection("Sequential")]
    public class StartPageTests : TestBase
    {
        public StartPageTests()
        {
            LaunchCoockieClickerApplication();
            StartTheGameByEnteringPlayerName();
        }

        [Fact]
        public void VerifyTheSectionsOfStartPage()
        {
            // Verifyiong the Hello message at the Landing page.
            startPage.WelcomeMessage.Displayed.Should().BeTrue();
            // Verifying Cookies section is present with the default 0 value
            startPage.Cookies.Displayed.Should().BeTrue();
            startPage.Cookies.Text.Should().Be(Constants.Zero);
            // Verifying Factories section is present woith default 0 value
            startPage.Factories.Displayed.Should().BeTrue();
            startPage.Factories.Text.Should().Be(Constants.Zero);
            // Verifying Moneys section is present woith default 0 value
            startPage.Money.Displayed.Should().BeTrue();
            WaitForApplictionToLaodOrSync();
            startPage.Money.Text.Should().Be(Constants.Zero);           
            startPage.ClickCookieButton.Displayed.Should().BeTrue();
            startPage.SellCookiesInputBox.Displayed.Should().BeTrue();
            startPage.SellCookiesButton.Displayed.Should().BeTrue();
            startPage.BuyFactoriesInputBox.Displayed.Should().BeTrue();
            startPage.BuyFactoriesButton.Displayed.Should().BeTrue();
        }

        [Fact]
        public void VerifySellCookiesFunctionality()
        {
            CollectCookies(5);
            WaitForApplictionToLaodOrSync();
            startPage.Cookies.Text.Should().Be("5");
            SellCookies(Constants.SpecialCharacter);
            startPage.Cookies.Text.Should().Be("5");
            SellCookies(Constants.DecimalValue);
            startPage.Cookies.Text.Should().Be("5");
            SellCookies(Constants.Zero);
            startPage.Cookies.Text.Should().Be("5");
            SellCookies(Constants.NegativeValue);
            startPage.Cookies.Text.Should().Be("5");
        }

        [Theory]
        [InlineData(Constants.SpecialCharacter)]
        [InlineData(Constants.DecimalValue)]
        [InlineData(Constants.Zero)]
        [InlineData(Constants.ValidNumber)]
        public void VerifyBuyFactories(string value)
        {
            WaitForApplictionToLaodOrSync();
            startPage.Cookies.Text.Should().Be(Constants.Zero);
            startPage.Factories.Text.Should().Be(Constants.Zero);
            startPage.Money.Text.Should().Be(Constants.Zero);
            BuyFactories(value);
            startPage.Factories.Text.Should().Be(Constants.Zero);
        } 
    }
}
