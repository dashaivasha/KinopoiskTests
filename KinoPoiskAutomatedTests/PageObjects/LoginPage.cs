using OpenQA.Selenium;

namespace KinoPoiskAutomatedTests.PageObjects
{
    public class LoginPage
    {
        private By UserIDInput = By.XPath("//*[@id='passp-field-login']");
        private By EmailChoose = By.XPath("//div[@class='AuthLoginInputToggle-type'][2]/button");
        private By Submit = By.XPath("//*[@id='passp:sign-in']");

        public void EnterLoginAndSubmit(IWebDriver driver, string login)
        {
            if (IsEmailChooseExist())
            {
                driver.FindElement(EmailChoose).Click();
            }

            driver.FindElement(UserIDInput).SendKeys(login);
            driver.FindElement(Submit).Submit();
        }

        public bool IsEmailChooseExist()
        {
            if (EmailChoose == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
