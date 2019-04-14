using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using PageObjectModelFramework.CommonFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelFramework.WebPages
{
    class HomePage
    {
        //Define HomePage Objects and Actions here
        //Page Objects:
        public static IWebDriver localDriver = BrowserManagement.localDriver;
       public static string userNameLable = "//td[contains(text(),'User: Sudha Panchaparvala')]";
       public static string contactsLinkXpath = "//a[contains(text(), 'Contacts')]";
       public static string reportsLinkXpath = "//a[contains(text(), 'Reports')]";
       public static string dealsLinkXpath = "//a[contains(text(), 'Deals')]";
       public static string newContactLinkXpath = "//a[text() = 'New Contact']";
      //  IWebElement contactsLink = localDriver.FindElement(By.XPath("//a[text()= 'Contacts']")); 
      //--> this is not allowing because of frames involved in th page. 
      // --> we can find the element only after switching to the frame

        //Actions:
        public string homePageTitle()
        {
            return localDriver.Title;
            
        }
        public bool verifyUserName()
        {
            // 
            // return userNameLable.Displayed;
            BrowserManagement.moveToFrame();
            return localDriver.FindElement(By.XPath(userNameLable)).Displayed;
                        
        }
        public ContactsPage clickOnContactsLink()
        {
            BrowserManagement.moveToFrame();
            ExtensionMethods.clickByXpath(contactsLinkXpath);
            return new ContactsPage();
        }
        public DealsPage clickOnDealsLink()
        {
            BrowserManagement.moveToFrame();
            // IWebElement dealsLink = localDriver.FindElement(By.XPath("//a[contains(text(), 'Deals')]"));
            //dealsLink.Click();
            
            ExtensionMethods.clickByXpath(dealsLinkXpath);
            return new DealsPage();
        }
        public ReportsPage clickOnReportsLink()
        {
            BrowserManagement.moveToFrame();
            // IWebElement reportsLink = localDriver.FindElement(By.XPath("//a[contains(text(), 'Reports')]"));
            //reportsLink.Click();

           ExtensionMethods.clickByXpath(reportsLinkXpath);
            return new ReportsPage();
        }
        public void clickOnNewContactsMenu()
        {
            BrowserManagement.moveToFrame();
            // IWebElement contactsLink = localDriver.FindElement(By.XPath("//a[contains(text(), 'Contacts')]"));
            //IWebElement newContactLink = localDriver.FindElement(By.XPath("//a[text() = 'New Contact']"));
            // action.MoveToElement(contactsLink).Build().Perform();
            // newContactLink.Click();

            Actions action = new Actions(localDriver);    
            action.MoveToElement(localDriver.FindElement(By.XPath(contactsLinkXpath))).Build().Perform();
            ExtensionMethods.clickByXpath(newContactLinkXpath);
                
        }
    }
}
