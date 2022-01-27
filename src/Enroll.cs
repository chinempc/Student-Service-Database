using System;
using System.Runtime.dll


namespace StudentServiceDatabase {
    public class Enroll {
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
