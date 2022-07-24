using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Bank
{
    internal class User:Account
    {
        private string firstname;
        private string lastname;
        private string email;
        private string phoneNumber;
        private string address;
        private Account account;
        private Payment payment; 

        public User(string firstname, string lastname, string email, string phoneNumber, Account account, Payment payment)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            PhoneNumber = phoneNumber;
            this.account = account;
            this.payment = payment;
            
        }
        public User()
        {

        }

        public string Firstname
        {
            set { firstname = value; }
            get { return firstname; }
        }
        public string Lastname
        {
            set { lastname = value; }
            get { return lastname; }
        }
        public string Email
        {
            set { email = value; }
            get
            {
                return email;
            }
        }
        public string PhoneNumber
        {
            set { phoneNumber = value; }
            get
            {
                return phoneNumber;
            }
        }

        public string Address
        {
            set { address = value; }
            get
            {
                return address;
            }
        }

        public Account Account
        {
            get
            {
                return account;
            }
        }
        public Payment Payment
        {
            get { return payment; }
        }
    }
}
