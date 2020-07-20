using MarsQA_1.Helpers;
using MarsQA_1.Utils;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Pages
{
    [Binding]
    public class SignIn
    {
        //Click on Sign in
        private static IWebElement SignInBtn =>  Driver.driver.FindElement(By.XPath("//a[@class='item']"));
        //Enter Username
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("//input[@name='email']"));
        //Enter Password
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//input[@name='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//button[@class='fluid ui teal button' ]"));
        
        [Given(@"User Launch the website")]

        public static void Launchurl()
        {
            Driver.TurnOnWait();
            Driver.NavigateUrl();

        }
        [Given(@"Click on Signin button")]

        public static void SigninClick()
        {
            Driver.TurnOnWait();
            SignInBtn.Click();

        }
        [When(@"User enter Login details")]

        public static void SigninStep()
        {

            ExcelLibHelper.PopulateInCollection(@"D:\Mars\AdvancedTaskTeam-master\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Login.xlsx", "Login");
            Email.SendKeys(ExcelLibHelper.ReadData(2,"Username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
        }
        [Then(@"Click on login button")]

        public static void LoginClick()
        {
            LoginBtn.Click();

        }
    }
}