using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddNewContactTests : AuthTestBase
    {
        [Test]
        public void AddNewContactTest()
        {
            app.ContactHelper.CreateContact();
        }
    }
}