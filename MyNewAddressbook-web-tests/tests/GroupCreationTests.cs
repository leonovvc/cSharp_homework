using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("testName");
            group.Header = null;
            group.Footer = ("testFooter");
            app.GroupHelper.CreateGroup(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = ("");
            group.Footer = ("");
            app.GroupHelper.CreateGroup(group);
        }
    }
}
