using System;
using System.Runtime.dll


namespace StudentServiceDatabase {
    public class Enroll {
	private DateTime DateCreated;
        private int Grade;
        private Student EnrolledStudent;
        private Courses EnrolledCourse;
        public Enroll(Student stu, Courses cours){
            EnrolledStudent = stu;
	    EnrolledCourse = cours;
	    DateCreated = DateTime.Now;
        }
	
	public void SetGrade(int _grade) {
	    Grade = _grade;
	}
	
	public int GetGrade() {
	    return Grade;
	}
	
	public GetStudent() {
	    return EnrolledStudent;
	}
	
	public GetCourse() {
	    return EnrolledCourse;
	}
    }
}
