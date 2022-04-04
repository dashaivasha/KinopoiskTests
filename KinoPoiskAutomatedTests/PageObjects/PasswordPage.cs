using KinoPoiskAutomatedTests.WebDriver;
using OpenQA.Selenium;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class PasswordPage : BasePage
    {
        private By _passwordInput => By.XPath("//*[@id='passp-field-passwd']");
        private IWebElement _signInButton => driver.FindElement(By.XPath("//*[@id='passp:sign-in']"));

        public void EnterPasswordAndEnter(string password)
        {
            WebDriverExtensions.FindElement(driver,_passwordInput,20).SendKeys(password);
            _signInButton.Submit();
        }
    }
}
