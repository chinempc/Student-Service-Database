using System;


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
            enrollees.Add(NewEnrollee);
        }

        public void RemoveEnrollees(enroll[] EnrolleesToRemove) {
            foreach (var i in EnrolleesToRemove) {
                enrollees.Remove(i);
            }
        }
    }
}