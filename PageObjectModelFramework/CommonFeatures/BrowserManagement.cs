using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectModelFramework;
using PageObjectModelFramework.Global;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using RelevantCodes.ExtentReports;

namespace PageObjectModelFramework.CommonFeatures
{
    class BrowserManagement
    {
        //driver initialization and launching the Browser
        //https://classic.crmpro.com/login.cfm

        public static IWebDriver localDriver = Driver.driver;  //driver object access from Global Driver class
        public static ExtentReports report;
        public static ExtentTest test;
        public static void openBrowser()
        {
            localDriver = new ChromeDriver();  //Initialize to Chrome driver
            localDriver.Navigate().GoToUrl("https://classic.crmpro.com/index.html");

            localDriver.Manage().Window.Maximize();
            // localDriver.Manage().Timeouts().ImplicitWait.Seconds.Equals(10);

            //Report initialization
            report = new ExtentReports("C:/Users/538067/source/repos/PageObjectModelFramework/PageObjectModelFramework/Reports/ReportPage.html", false, DisplayOrder.OldestFirst);
            report.LoadConfig("C:/Users/538067/source/repos/PageObjectModelFramework/PageObjectModelFramework/Reports/extentConfig.xml");
        }
        public static void closeBrowser()
        {
            
            report.EndTest(test);
            report.Flush();   //To flush the data into the report at the end of the test case.

            localDriver.Quit();  //Closing all instances of the browser
        }

        public static void moveToFrame()
        {
            localDriver.SwitchTo().Frame("mainpanel");

        }

        //generalised method : write test name to the report
        public static void extentReportStartTestName(string msg)
        {
            test = report.StartTest(msg);

        }
        public static void extentReportPassTestLog(string passMsg)
        {
            test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, passMsg);  // add the message to the report when the test is passed
        }
        public static void extentReportsFailTestLog(string failMsg)
        {
            test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, failMsg);  // add the message to the log when the test is failed
        }


        
    }
}
