using NUnit.Framework;
using PageObjectModelFramework.WebPages;
using PageObjectModelFramework.CommonFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelFramework.TestCases
{
    class LoginPageTest
    {
        //Actual testing for the Login page test plan

        LoginPage loginPage;
        HomePage homePage;

        [SetUp]
        public void setUp()
        {
            BrowserManagement.openBrowser();
            loginPage = new LoginPage();
        }
        [Test]
        public void LoginTest01VerifyLoginPageTitle()
        {
            try
            {
                //BrowserManagement.test = BrowserManagement.report.StartTest("Test Login");
                BrowserManagement.extentReportStartTestName("Test Login");
                Assert.AreEqual("CRMPRO - CRM software for customer relationship management, sales, and support.", loginPage.loginPageTitle(), "Login page title not matched");
                //Console.WriteLine("Successful login");
                // BrowserManagement.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login successful");
                BrowserManagement.extentReportPassTestLog("Correct Login page");
            }
            catch (Exception ex)
            {
                //BrowserManagement.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login unsuccessful");
                Console.WriteLine("Login is not successful" + ex.InnerException);
                BrowserManagement.extentReportsFailTestLog("Page Title is not matched");

            }
        }
        [Test]
        public void LoginTest02CheckLoginPageImage()
        {
            try
            {
                //BrowserManagement.test = BrowserManagement.report.StartTest("Login page image Test");
                BrowserManagement.extentReportStartTestName("Login page image test");
                Assert.IsTrue(loginPage.validateCRMImage());
                // BrowserManagement.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login page image matched");   
                BrowserManagement.extentReportPassTestLog("Login page image is matched");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Login page image is not matched" + ex.InnerException);
                // BrowserManagement.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login page image not matched");
                BrowserManagement.extentReportsFailTestLog("Login page image is not matched");
            }
        }
        [Test]
        public void LoginTest03LoginTest()
        {
            BrowserManagement.extentReportStartTestName("Test for Login to the Application");
            homePage = loginPage.loginMethod();
            BrowserManagement.extentReportPassTestLog("Login successfully");
        }

        [TearDown]
        public void closeBrowser()
        {
            BrowserManagement.closeBrowser();
        }

    }
}
