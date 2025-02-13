using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Student Details");
            Student student = new Student(1, "Taha", 12, "example@gmail.com" , "B", "Maths");
            student.showStudent();

            Console.WriteLine("Student Details");
            Student student = new Student(1, "Shahzad", 01, "example@gmail.com" , "B", "Maths");
            student.showStudent();
            //Student s = (Student)Person;

            Console.WriteLine("Teacher Details");
            Teacher teacher = new Teacher(1, "Ali", 40, "example@gmail.com", "Maths", 10);
            teacher.getTeacherDetails();

            Console.WriteLine("Administrator Details");
            Administrator admin = new Administrator(1, "Subhan", 40, "example@gmail.com", "Admission" , "admin");
            admin.getAdministratorDetails();
        }
    }
}
