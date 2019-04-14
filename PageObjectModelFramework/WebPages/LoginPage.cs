using OpenQA.Selenium;
using PageObjectModelFramework.CommonFeatures;
using PageObjectModelFramework.Inputs;
using System.Threading;

namespace PageObjectModelFramework.WebPages
{
    class LoginPage
    {
        //Define all the WebElements and Methods related to the Login Page
        //username = sudhatumu    sudha86.tumu@gmail.com
        //password = test123   Test@123

        //Members:
        public static IWebDriver localDriver = BrowserManagement.localDriver;
        

        //Actions:
        public string loginPageTitle()
        {
            return localDriver.Title;
        }

        public bool validateCRMImage()
        {
            IWebElement crmLogo = localDriver.FindElement(By.XPath("//img[@class = 'img-responsive' and @src = 'https://classic.crmpro.com/img/logo.png']"));
            return crmLogo.Displayed;
        }

        public HomePage loginMethod()
        {
            //returns the HomePage after logging in

            //localDriver.FindElement(By.XPath("//input[@name='username']")).SendKeys("sudhatumu");
            //localDriver.FindElement(By.XPath("//input[@name='password']")).SendKeys("test123");
            //localDriver.FindElement(By.XPath("//input[@name='username']")).SendKeys(LoginResouces.username);
            //localDriver.FindElement(By.XPath("//input[@name='password']")).SendKeys(LoginResouces.password);
            Thread.Sleep(2000);

            ExtensionMethods.sendKeysByXpath("//input[@name='username']", LoginResouces.username);
            ExtensionMethods.sendKeysByXpath("//input[@name='password']", LoginResouces.password);


            // localDriver.FindElement(By.XPath("//input[@type='submit']")).Click();
            IWebElement loginBtn = localDriver.FindElement(By.XPath("//input[@type='submit']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)localDriver;
            js.ExecuteScript("arguments[0].click();", loginBtn);

            return new HomePage();

        }
        
    }
}
