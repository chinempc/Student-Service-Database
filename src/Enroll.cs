using System;
using System.Runtime.dll


namespace StudentServiceDatabase {
    public class Enroll {
        // Date time for loggin when a student was registered to take a course
	private DateTime DateCreated;
        private int Grade { get; set;}
        private Student EnrolledStudent;
        private Courses EnrolledCourse;
        public Enroll(Student stu, Courses cours){
            EnrolledStudent = stu;
	    EnrolledCourse = cours;
	    DateCreated = DateTime.Now;
        }
    }
}
