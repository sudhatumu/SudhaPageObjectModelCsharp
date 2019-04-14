using NUnit.Framework;
using PageObjectModelFramework.CommonFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectModelFramework.WebPages;

namespace PageObjectModelFramework.TestCases
{
    class TestController
    {
        //Controlling all the test cases for all the pages from here
        LoginPage loginPage;

        [SetUp]
        public void setUp()
        {
            loginPage = new LoginPage();
            BrowserManagement.openBrowser();
           
        }
        [Test]
        public void TestCase1LoginPageTest()
        {
            loginPage.loginMethod();
            Assert.AreEqual("CRMPRO", loginPage.loginPageTitle());
        }

        [TearDown]
        public void closeBrowser()
        {
            BrowserManagement.closeBrowser();
        }
    }
}
