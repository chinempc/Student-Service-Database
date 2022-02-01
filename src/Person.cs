using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServeData
{
    class Person
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        //Address Ad;
        private string phoneNumber;

        Person(string fname, string lname, DateTime dateB, string phoneNum)
        {
            firstName = fname;
            lastName = lname;
            dateOfBirth = dateB;
            phoneNumber = phoneNum;
        }

        public void AddAddress()
        {
            ;
        }
    }
}
