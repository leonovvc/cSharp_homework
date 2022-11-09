using System;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            app.GroupHelper.Remove(1);
        }

        [Test]
        public void CheckAndRemoveTest()
        {
            GroupData group = new GroupData("testName");
            group.Header = ("testHeader");
            group.Footer = ("testFooter");

            if (!app.GroupHelper.FoundGroup())
            {
                app.GroupHelper.CreateGroup(group);
            }
            app.GroupHelper.Remove(1);
        }
    }


}
