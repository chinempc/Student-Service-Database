using System;
using System.Collections.Generic;


namespace StudentServiceDatabase {
    public class Courses {
        public int MinStudents, MaxStudents, CourseCode;
        public Lists<professor> professors = new List<professor>();
        Lists<enroll> enrollees = new List<enroll>();

        public Courses(int min, int max, int code, professor BaseProfessor) {
            MinStudents = min;
            MaxStudents = max;
            CourseCode = code;
            professors.Add(BaseProfessor);
        }

        public bool IsCanceled() {
            return enrollees.Length < MinStudents;
        }

        public void AddProfessor(professor NewProfessor) {
            professors.Add(NewProfessor);
        }

        public void AddProfessors(professor[] NewProfessors) {
            // Adding multiple professors at a time
            foreach (var i in NewProfessors) {
                professors.Add(i);
            }
        }

        public void RemoveProfessor(professor ProfessorToRemove) {
            professors.Remove(ProfessorToRemove);
        }

        public void RemoveProfessors(professor[] ProfessorsToRemove) {
            foreach (var i in ProfessorsToRemove) {
                professors.Remove(i);
            }
        }

        public void AddEnrollee(enroll NewEnrollee) {
            if(enrollees.Count < MaxStudents) {
                enrollees.Add(NewEnrollee);
                Console.WriteLine("New student has been added! There are " + MaxStudents - enrollees.Count + " seats available for this course.\n");
            } else {
                Console.WriteLine("Max number of students have been reached for this course! Cannot add new student.\n");
        }

        public void AddEnrollees(enroll[] EnrolleesToAdd) {
            if(enrollees.Count < MaxStudents & EnrolleesToAdd.Length <= MaxStudents-enrollees.Count) {
                foreach (var i in EnrolleesToAdd) {
                    enrollees.Add(i);
                }
                Console.WriteLine("New students has been added! There are " + MaxStudents - enrollees.Count + " seats available for this course.\n");
            } else if (EnrolleesToAdd.Length > MaxStudents-enrollees.Count) {
                Console.WriteLine("Number of students passed in exceeds the number of students allowed for this course by " + EnrolleesToRemove.Length-MaxStudents-enrollees.Count + ".\n");
            } else {
                Console.WriteLine("Max number of students have been reached for this course! Cannot add new student.\n");
            }
        }
            
        public void RemoveEnrollee(enroll EnrolleeToRemove) {
            if(!enrollees.Remove(EnrolleeToRemove) {
                Console.WriteLine("Enrollee does not exist for this course!\n");
            } else {
                Console.WriteLine("Student removed from enrollees!");
            }
        }
            
        public void RemoveEnrollees(enroll[] EnrolleesToRemove) {
            foreach (var i in EnrolleesToRemove) {
                if(!enrollees.Remove(EnrolleeToRemove) {
                    Console.WriteLine("Enrollee does not exist for this course!\n");
                } else {
                    Console.WriteLine("Student removed from enrollees!");
                }
            }
        }
    }
}
