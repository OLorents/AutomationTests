using OpenQA.Selenium;


namespace AdvertisingSeleniumtests.Pages
{
    internal class SubmitPage
    {
        private readonly IWebDriver _driver;
        public SubmitPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement firstNameWebElement => _driver.FindElement(By.CssSelector("input[placeholder='Enter First Name...']"));
        private IWebElement lastNameWebElement => _driver.FindElement(By.CssSelector("input[placeholder='Enter Last Name...']"));
        private IWebElement emailWebElement => _driver.FindElement(By.CssSelector("input[placeholder='Enter Email...']"));
        private IWebElement phoneWebElement => _driver.FindElement(By.CssSelector("input[placeholder='Enter Phone...']"));
        private IWebElement stateWebElement => _driver.FindElement(By.CssSelector("input[placeholder='Enter State...']"));
        private IWebElement reasonWebElement => _driver.FindElement(By.CssSelector("input[placeholder='Enter Reason...']"));
        private IWebElement submitButton => _driver.FindElement(By.XPath("//button[@type='submit']"));
        private IWebElement firstNameRequired => _driver.FindElement(By.XPath("//span[contains(@class, 'add-set-error') and text()='First Name Required']"));

        public void EnterFirstName(string text)
        {
            firstNameWebElement.SendKeys(text);
        }

        public void EnterLastName(string text)
        {
            lastNameWebElement.SendKeys(text);
        }

        public void EnterEmail(string text)
        {
            emailWebElement.SendKeys(text);
        }

        public void EnterPhone(string text)
        {
            phoneWebElement.SendKeys(text);
        }

        public void EnterState(string text)
        {
            stateWebElement.SendKeys(text);
        }

        public void EnterReason(string text)
        {
            reasonWebElement.SendKeys(text);
        }

        public string GetFistNameFieldValue()
        {
            return firstNameWebElement.GetAttribute("value");
        }

        public string GetLastNameFieldValue()
        {
            return lastNameWebElement.GetAttribute("value");
        }
        public string GetEmailFieldValue()
        {
            return emailWebElement.GetAttribute("value");
        }
        public string GetPhoneFieldValue()
        {
            return phoneWebElement.GetAttribute("value");
        }
        public string GetStateFieldValue()
        {
            return stateWebElement.GetAttribute("value");
        }

        public string GetReasonFieldValue()
        {
            return reasonWebElement.GetAttribute("value");
        }
        public void ClickSubmitButton()
        {
            submitButton.Click();
        }
        public string FirstNameRequired()
        {
            return firstNameRequired.Text;
        }
    }
}
