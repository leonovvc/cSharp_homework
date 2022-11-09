using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("testName");
            group.Header = ("testHeader");
            group.Footer = ("testFooter");
            app.GroupHelper.CreateGroup(group);
            app.Auth.Logout();
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = ("");
            group.Footer = ("");
            app.GroupHelper.CreateGroup(group);
            app.Auth.Logout();
        }
    }
}
