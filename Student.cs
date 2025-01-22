using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPS_project_2
{
    internal class Student : Person
    {
        // Student student = new Student(int id, string name, int age, string email);
        private string Grade { get ; set; }
        private string Subject { get; set;  }

        public Student(int id, string name, int age, string email , string grade , string subject ) 
            : base(id, name, age, email)
        {
            this.Subject = subject;
            this.Grade = grade;
        }
        public void showStudent()
        {
            showDetails();
            Console.WriteLine(Grade);
            Console.WriteLine(Subject);

        }
    }
}
