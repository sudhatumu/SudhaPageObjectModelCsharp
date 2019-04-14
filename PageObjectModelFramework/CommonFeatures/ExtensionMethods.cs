using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelFramework.CommonFeatures
{
    class ExtensionMethods
    {
        public static IWebDriver localDriver = BrowserManagement.localDriver;
      
        //We define the generic methods to handle the webelements here
        public static void sendKeysByXpath(string xpath,string text)
        {
            localDriver.FindElement(By.XPath(xpath)).SendKeys(text);

        }
        public static void clickByXpath(string xpath)
        {
            localDriver.FindElement(By.XPath(xpath)).Click();
        }
        public static void sendKeysById(string id, string text)
        {
            localDriver.FindElement(By.Id(id)).SendKeys(text);
        }
        public static void clickById(string id)
        {
            localDriver.FindElement(By.Id(id)).Click();
        }

    }
}
