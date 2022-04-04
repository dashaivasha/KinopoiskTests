using KinoPoiskAutomatedTests.WebDriver;
using OpenQA.Selenium;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class LoginPage : BasePage
    {
        private By _userIdInput  => By.XPath("//*[@id='passp-field-login']");
        private IWebElement Submit => driver.FindElement(By.XPath("//*[@id='passp:sign-in']"));

        public void EnterLoginAndSubmit(string login)
        {
            WebDriverExtensions.FindElement(driver,_userIdInput,Data.WaitTime).SendKeys(login);
            Submit.Submit();
        }
    }
}
