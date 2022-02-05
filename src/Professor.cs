using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceDatabase
{
    class Professor : Person
    {
        private double salary;
        private List<Courses> teaching = new List<Courses>();
        private bool ReceivedRaise;
        private MaxCourses = 6;

        Professor(double sal, string fname, string lname, DateTime dateB, string phoneNum, Address ad) : base(fname, lname, dateB, phoneNum, ad)
        {
            salary = sal;
        }

        public void Eligible4Bonus()
        {
            if (ReceivedRaise) {
                Console.WriteLine($"{this.FirstName} has already recieved their salary boost...");
                return;
            } 
            // Check if they are teaching more than 4 courses
            if (teaching.Count > 4) {
                salary += 20000;
                RecievedRaise = true;
            }
        }

        public void AddCourse(Courses CourseToAdd)
        {
            // Account for duplicates
            if (teaching.Contains(CourseToAdd)) {
                Console.WriteLine("This course is already being taught by this professor.\nCourse was not added...")
                return;
            }
            teaching.Add(CourseToAdd);
        }

        public void AddCourses(Courses[] CoursesToAdd) {
            if(teaching.Count < MaxCourses & CoursesToAdd.Length <= MaxCourses - teaching.Count) {
                foreach (var i in CoursesToAdd) {
                    // account for duplicates
                    if (teaching.Contains(i)) {
                        Console.WriteLine(i.CourseCode + " is already being taught by this professor.\nCourse was not added...")
                        continue;
                    }
                    teaching.Add(i);
                }
                Console.WriteLine("New Courses has been added! There are " + MaxCourses - teaching.Count + " Course available to be taught by professor " + this.FirstName + ".\n");
            } else if (CoursesToAdd.Length > MaxCourses - teaching.Count) {
                Console.WriteLine("Number of Courses passed in exceeds the number of Courses allowed to be taught professor " + this.FirstName + " by " + CoursesToAdd.Length - MaxCourses - teaching.Count + ".\n");
            } else {
                Console.WriteLine("Max number of Courses to be taught by " + this.FirstName + "have been reached! Cannot add new Course.\n");
            }
        }

        public void RemoveCourse(Courses CourseToRemove)
        {
            if (!teaching.Remove(CourseToRemove)) {
                Console.WriteLine("This course does not exist in this professor's list of courses...");
            } else {
                Console.WriteLine("Course has been removed...");
            }
        }

        public vod RemoveCourses(Courses[] CoursesToRemove) {
            foreach (var i in CoursesToRemove) {
                teaching.Remove(i);
            }
        }

        public void ChangeStudentGrade(Student stud, Course StudentCourse int ChangedGrade)
        {}
    }
}
