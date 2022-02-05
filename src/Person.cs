using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceDatabase
{
    class Person
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        Address Ad;
        private string phoneNumber;

        Person(string fname, string lname, DateTime dateB, string phoneNum)
        {
            firstName = fname;
            lastName = lname;
            dateOfBirth = dateB;
            phoneNumber = phoneNum;
        }
        
        public void  AddAddress(Address NewAddress) {
            Ad.Add(NewAddress);
            Console.WriteLine("Address Added...");
        }

        public void AddAddress(Address[] NewAddresses) { 
            // Adding multiple Addresses at a time
            foreach (var i in NewAddresses) {
                Ad.Add(i);
                Console.WriteLine("Address Added...");
            }
        }
        public void RemoveAddress()
        {
            ;
        }
    }
}