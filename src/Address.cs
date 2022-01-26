using System;


namespace StudentServiceDatabase {
    public class Address {
        private string streetName, city, state, country;
        private int streetNumber, zip;
        public Address(int strNum, string street, string cty, string st, string cntry, int zipCode){
            streetNumber = strNum;
            streetName = street;
            city = cty;
            state = st;
            country = cntry;
            zip = zipCode;
        }
    }
}