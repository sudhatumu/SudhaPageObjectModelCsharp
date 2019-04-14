using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PageObjectModelFramework.CommonFeatures;

namespace PageObjectModelFramework.WebPages
{
    class ContactsPage
    {
        public static IWebDriver localDriver = BrowserManagement.localDriver;
        //Page Objects:
        public static string firstNameId = "first_name";
        public static string lastNameId = "surname";
        public static string saveButtonXpath = "//form[@id = 'contactForm']//input[@type = 'submit' and @value = 'Save']";

        //Actions:
        // Input new contact details from Exceldata - Data driven concept using excel
        public void inputNewContact()
        {
            ExcelData.PopulateInCollection("C:/Users/538067/source/repos/PageObjectModelFramework/PageObjectModelFramework/Inputs/ContactsInput.xlsx", "Sheet1");
            
           for ( int row=2;  row <=6; row++)
            {
                ExtensionMethods.sendKeysById(firstNameId, ExcelData.ReadData(row, "firstname"));
                ExtensionMethods.sendKeysById(lastNameId, ExcelData.ReadData(row, "lastname"));
                ExtensionMethods.clickByXpath(saveButtonXpath);
            }

        }
    }
}
