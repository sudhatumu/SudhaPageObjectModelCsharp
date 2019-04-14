using NUnit.Framework;
using PageObjectModelFramework.CommonFeatures;
using PageObjectModelFramework.WebPages;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelFramework.TestCases
{
    class HomePageTest
    {
        LoginPage loginPage;
        HomePage homePage;
        ContactsPage contactsPage;
        DealsPage dealsPage;
        ReportsPage reportsPage;
        // All test cases should be independent

        [SetUp]
        public void setUp()
        {
            BrowserManagement.openBrowser();
            loginPage = new LoginPage();
            homePage = new HomePage();
            contactsPage = new ContactsPage();
            dealsPage = new DealsPage();
            reportsPage = new ReportsPage();

            homePage = loginPage.loginMethod(); //Loggin in to the site

        }
        [Test]
        public void HomePageTest01verifyHomePageTitle()
        {
            try
            {
                BrowserManagement.extentReportStartTestName("Home Page Title Test");
                Assert.AreEqual("CRMPRO", homePage.homePageTitle(), "Home page Title is not matched");
                BrowserManagement.extentReportPassTestLog("Home Page Title is matched");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Home Page Title is not matched" + ex.InnerException);
                BrowserManagement.extentReportsFailTestLog("Home Page title is not matched");
            }
        }
        [Test]
        public void HomePageTest02verifyUserName()
        {
            try
            { 
                BrowserManagement.extentReportStartTestName("Home Page User name Test");
                Assert.IsTrue(homePage.verifyUserName());
                BrowserManagement.extentReportPassTestLog("User name is matched with expected one");
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.InnerException);
                BrowserManagement.extentReportsFailTestLog("Unexpected user name");
            }
           
        }
        [Test]
        public void HomePageTest03verifyContactsLink()
        {
            try
            {
                homePage.clickOnContactsLink();
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.InnerException);
            }
            
        }
        public void HomePageTest04verifyDealsLink()
        {
            try
            {
                homePage.clickOnDealsLink();
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.InnerException);
            }
            
        }
        public void HomePageTest05clickOnNewContact()
        {
            try
            {
                homePage.clickOnNewContactsMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.InnerException);
            }
            
        }
        [TearDown]
        public void tearDown()
        {
            BrowserManagement.closeBrowser();
        }

    }
}
