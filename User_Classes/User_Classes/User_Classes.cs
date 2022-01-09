using System;

namespace User_Classes
{
    public class User/*Question for User chinempc: Do you think we should have classes with inheritence or just classes?*/
    {
        public User()
        {
            ;
        }
        ~User()
        {

        }
    }
    public class Student : User
    {
        string sFName;
        string sLName;
        string address;
        int age;
        int phone_Number;//String or int?

        Student()
        {

        }

        ~Student()
        {
            ;
        }
            
    }
    public class Professor : User
    {
        string pFName;
        string pLName;
        string address;
        int age;
        int phone_Number;//String or int?

        Professor()
        {

        }
        ~Professor()
        {

        }
    }
    public class Courses
    {
        /*Should we use an enumerator(enum) for this or am I over thinking it...*/
        Courses()
        {

        }
        ~Courses()
        {

        }
    }
    public class User_Classes //Driver class where Main will be executed...
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Classes are made but are very bare bones...");
        }
    }
}
