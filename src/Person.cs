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
        List<Address> addresses = new List<Address>();
        private string phoneNumber;

        Person(string fname, string lname, DateTime dateB, string phoneNum, Address ad)
        {
            firstName = fname;
            lastName = lname;
            dateOfBirth = dateB;
            phoneNumber = phoneNum;
            addresses.Add(ad);
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
        
        public void RemoveAddress(Address AddressToRemove)
        {
            if(!addresses.Remove(AddressToRemove)) {
                Console.WriteLine("Address does not exist...");
            } else {
                Console.WriteLine("Address has been removed...");
            }
        }
       
        public void RemoveAdresses(Address[] AddressesToRemove) {
            foreach(var i in AddressesToRemove) {
                if(!addresses.Remove(AddressToRemove)) {
                    Console.Log("Address does not exist...");
                } else {
                    Console.WriteLine("Address has been removed...");   
                }
            }
        }
    }
}
