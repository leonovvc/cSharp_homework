using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using WebAddressbookTests;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddNewContactTests : TestBase
    {
        [Test]
        public void AddNewContactTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToAddNewPage();
            AddNewContact main = new AddNewContact("Test","Testov");
            FillAddNewForm(main);
            SubmitCreationContact();
            ReturnToMainPage();
            Logout();
        }

    }
}