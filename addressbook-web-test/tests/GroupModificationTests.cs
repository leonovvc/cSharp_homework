using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("someTest");
            newData.Header = ("newHeader");
            newData.Footer = ("newFooter");

            app.GroupHelper.Modify(1, newData);
        }
    }
}
