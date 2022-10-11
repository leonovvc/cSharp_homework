using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddNewContactTests : TestBase
    {
        [Test]
        public void AddNewContactTest()
        {
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            contactHelper.GoToAddNewPage();
            AddNewContact main = new AddNewContact("Test","Testov");
            contactHelper.FillAddNewForm(main);
            contactHelper.SubmitCreationContact();
            contactHelper.ReturnToMainPage();
            groupHelper.Logout();
        }
    }
}