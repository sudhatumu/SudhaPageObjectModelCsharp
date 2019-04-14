using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectModelFramework.WebPages;
using PageObjectModelFramework.CommonFeatures;
using NUnit.Framework;

namespace PageObjectModelFramework.TestCases
{
    class ContactsPageTest
    {
        LoginPage loginPage;
        HomePage homePage;
        ContactsPage contactsPage;

        [SetUp]
        public void setUp()
        {
            BrowserManagement.openBrowser();
            loginPage = new LoginPage();
            homePage = new HomePage();
            contactsPage = new ContactsPage();

            homePage = loginPage.loginMethod();
            contactsPage = homePage.clickOnContactsLink();

        }
        [Test]
        public void createNewContact()
        {
            contactsPage.inputNewContact();

        }

    }
}
