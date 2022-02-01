using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServeData
{
    class Student
    {
        private bool IsInternation;
        //private List<Enroll> enrolles;

        Student(bool inter)
        {
            IsInternation = inter;
        }

        public bool IsPartTime()
        {
            return false;
        }
        public bool OnProbation()
        {
            return false;
        }
        public void AddCourse()
        {

        }
        public void RemoveCourse()
        {

        }
        public void ReportCard(int grade)
        {
            ;
        }
    }
}
