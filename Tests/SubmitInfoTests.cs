using AdvertisingSeleniumtests.Pages;
using AutomationFramework.Config;
using AutomationFramework.Driver;
using OpenQA.Selenium;

namespace AdvertisingSeleniumtests.Tests
{
    internal class SubmitInfoTests
    {
        IWebDriver _driver;
        SubmitPage _submitPage;

       [SetUp]
        public void SetUp()
        {
            var testSettings = new TestSettings
            {
                BrowserType = DriverFixtures.BrowserType.Chrome,
                ApplicationUrl = new Uri("https://automationtestwaui.azurewebsites.net/")
            };

            _driver = new DriverFixtures(testSettings).Driver;
            _submitPage = new SubmitPage(_driver);

        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }


        [Test]
        public void ContactInfo_ShouldBeSetSuccessfully()
        {

            //arrange
            var expectedFirstName = "Test First Name";
            var expectedLastName = "Test Last Name";
            var expectedEmail = "Test Email";
            var expectedPhone = "Test Phone";
            var expectedState = "Test State";
            var expectedReason = "Test Reason";

            //act
            _submitPage.EnterFirstName(expectedFirstName);
            _submitPage.EnterLastName(expectedLastName);
            _submitPage.EnterEmail(expectedEmail);
            _submitPage.EnterPhone(expectedPhone);
            _submitPage.EnterState(expectedState);
            _submitPage.EnterReason(expectedReason);


            //assert
            Assert.Multiple(() =>
            {
                Assert.That(_submitPage.GetFistNameFieldValue(), Is.EqualTo(expectedFirstName), "First name value is not correct");
                Assert.That(_submitPage.GetLastNameFieldValue(), Is.EqualTo(expectedLastName), "Last name value is not correct");
                Assert.That(_submitPage.GetEmailFieldValue(), Is.EqualTo(expectedEmail), "Email value is not correct");
                Assert.That(_submitPage.GetPhoneFieldValue(), Is.EqualTo(expectedPhone), "Phone value is not correct");
                Assert.That(_submitPage.GetStateFieldValue(), Is.EqualTo(expectedState), "State value is not correct");
                Assert.That(_submitPage.GetReasonFieldValue(), Is.EqualTo(expectedReason), "Reason value is not correct");
            });
        }

        [Test]
        public void FirstNameFielld_ShouldNotBeEmpty()
        {
            //arrange
            var expectedLastName = "Test Last Name";
            var expectedEmail = "Test Email";
            var expectedPhone = "Test Phone";
            var expectedState = "Test State";
            var expectedReason = "Test Reason";

            //act
            _submitPage.EnterLastName(expectedLastName);
            _submitPage.EnterEmail(expectedEmail);
            _submitPage.EnterPhone(expectedPhone);
            _submitPage.EnterState(expectedState);
            _submitPage.EnterReason(expectedReason);
            _submitPage.ClickSubmitButton();


            //assert
            Assert.Multiple(() =>
            {

                Assert.That(_submitPage.FirstNameRequired(), Is.EqualTo("First Name Required"), "First Name Required label is missing");
                Assert.That(_submitPage.GetLastNameFieldValue(), Is.EqualTo(expectedLastName), "Last name value is not correct");
                Assert.That(_submitPage.GetEmailFieldValue(), Is.EqualTo(expectedEmail), "Email value is not correct");
                Assert.That(_submitPage.GetPhoneFieldValue(), Is.EqualTo(expectedPhone), "Phone value is not correct");
                Assert.That(_submitPage.GetStateFieldValue(), Is.EqualTo(expectedState), "State value is not correct");
                Assert.That(_submitPage.GetReasonFieldValue(), Is.EqualTo(expectedReason), "Reason value is not correct");
            });
        }

    }
}
