using System;

namespace User_Classes
{
    public class Address : Person/*(Still stands) Question for User chinempc: Do you think we should have classes with inheritence or just classes?*/
    {
        //Should this class inherit from class Person?
        string Street;
        int streetNumber;
        string City;
        string State;
        string Country;
        int zipCode;

        Address()
        {

        }
        ~Address()
        {

        }
    
    }

    public class Person
    {
        string professorName;
        string dateOfBirth;
        Address Ad;
        int phoneNum;
    }

    public class Student : Person
    {
        bool international;
        bool fullTime;
        bool academicPro;
        int maxCourses;
        Student()
        {

        }

        ~Student()
        {

        }

        bool IsPartTime()
        {
            if(fullTime == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool IsOnProbation()
        {
            if (academicPro == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    public class Professor : Person
    {
        double salary;
        int salaryBonus = 20000;
        int numOfCourses;
        Professor()
        {

        }
        ~Professor()
        {

        }
        bool BonusEligable()
        {
            if(numOfCourses > 4)
            {
                salary += salaryBonus;
                return true;
            }
            else
            {
                //Do nothing...
                return false;
            }
        }
    }
    public class Courses
    {
        
        string courseName;
        string courseCode;
        int minStudents = 5; //example
        int maxStudents;
        int numOfStudents;

        public

        Courses()
        {

        }
        ~Courses()
        {

        }

        bool IsCancelled()
        {
            if(numOfStudents < minStudents)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Enroll : Courses
    {
        string date;//data type???
        float grade;
    }
    public class User_Classes //Driver class where Main will be executed...
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Classes are made but are very bare bones...");
        }
    }
}
