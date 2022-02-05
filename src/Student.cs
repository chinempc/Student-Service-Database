using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceDatabase
{
    class Student : Person
    {
        private bool IsInternation;
        private List<Enroll> EnrolledIn = new List<Enroll>();

        Student(bool inte = False, string fname, string lname, DateTime dateB, string phoneNum, Address ad) : base(fname, lname, dateB, phoneNum, ad)
        {}

        public bool IsPartTime()
        {
            return enrollees.Count <= 3;
        }

        public bool OnProbation()
        {
	    int total = 0;
            foreach(var i in EnrolledIn) {
	    	total += i.Grade;
	    }
	    return total/EnrolledIn.Count < 60;
        }

        public void AddCourse(CourseToEnroll)
        {
	    if(this.enrollees.Count < 6) {
	    	EnrolledIn.Add(CourseToEnroll)
	    } else {
	    	Console.WriteLine("Enroll failed; {0} has reached the max amount of coursese they can enroll in.", this.FirstName);
	    }
        }

        public void RemoveCourse(CourseToRemove)
        {
	    if(!EnrolledIn.Remove(CourseToRemove)) {
	    	Console.WriteLine("Course does not exist...");
	    } else {
	    	Console.WriteLine("Course has been removed...");
	    }
        }

        public void ReportCard()
        {
	    Console.WriteLine("{0}'s Report Card\n-------------------------");
            foreach(var i in EnrolledIn) {
	    	Console.WriteLine("{0} -> {1}\n", i.EnrolledCourse.CourseCode, i.Grade);
	    }
	    Console.WriteLine("-------------------------");
        }
    }
}
