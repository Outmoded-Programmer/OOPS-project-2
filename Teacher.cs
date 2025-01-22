using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_project_2
{
    internal class Teacher : Person
    {
        private string SubjectSpecialization { get; set; }
        private int yearOfExperiance { get; set; }
        public Teacher(int id  , string name , int age , string email , string SubjectSpecialization , int yearOfExperiance) :base(id , name , age , email)
        {
            this.SubjectSpecialization = SubjectSpecialization;
            this.yearOfExperiance = yearOfExperiance;
        }

        public void getTeacherDetails()
        {
            showDetails();
            Console.WriteLine(SubjectSpecialization);
            Console.WriteLine(yearOfExperiance);
        }
    }
}
