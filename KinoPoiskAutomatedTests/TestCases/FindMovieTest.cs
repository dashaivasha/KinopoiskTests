using System;
using KinoPoiskAutomatedTests.BaseClass;
using KinoPoiskAutomatedTests.PageObjects;
using KinoPoiskAutomatedTests.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace KinoPoiskAutomatedTests.TestCases
{
    [TestFixture]
    public class FindMovieTest : BaseTest
    {
        [Test]
        public void FindMovie()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            wait.Until(driver => homePage.SearchButton.Displayed);
            homePage.SearchButton.Click();  
            homePage.SearchInput.SendKeys(JsonManager.GetMovieName());
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(.//p,'') and contains(@class,'SuggestListItem')][1]")));
            homePage.SelectFilm = driver.FindElement(By.XPath("//div[contains(.//p,'') and contains(@class,'SuggestListItem')][1]"));
            homePage.SelectFilm.Click();
        }
    }
}
