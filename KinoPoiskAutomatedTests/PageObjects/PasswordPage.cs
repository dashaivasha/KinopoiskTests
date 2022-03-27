using OpenQA.Selenium;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class PasswordPage
    {
        private By _passwordInput = By.XPath("//*[@id='passp-field-passwd']");
        private By _signInButton = By.XPath("//*[@id='passp:sign-in']");

        public void EnterPasswordAndEnter(IWebDriver driver, string password)
        {
            driver.FindElement(_passwordInput).SendKeys(password);
            driver.FindElement(_signInButton).Submit();
        }
    }
}
