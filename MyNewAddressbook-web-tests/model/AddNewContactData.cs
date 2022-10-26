using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class AddNewContactData
    {
        private string firstName;
        private string middleName = "";
        private string lastName;
        private string nickName = "";
        private string title = "";
        private string company = "";
        private string address = "";
        private string homeTelephone = "";
        private string mobileTelephone = "";
        private string workTelephone = "";
        private string fax = "";
        private string email = "";
        private string email2 = "";
        private string email3 = "";
        private string homepage = "";
        private string secondaryAddress = "";
        private string secondaryHome = "";
        private string secondaryNotes = "";

        public AddNewContactData(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
    }

}
