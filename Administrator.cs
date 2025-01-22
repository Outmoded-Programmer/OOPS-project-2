using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_project_2
{
    internal class Administrator : Person
    {
        private string department { get; set; }
        private string position { get; set; }
        public Administrator(int id , string name , int age , string email , string department ,string position): base(id , name , age, email)
        {
            this.department = department;
            this.position = position;   
        }
        public void getAdministratorDetails()
        {
            showDetails();
            Console.WriteLine(department);
            Console.WriteLine(position);
        }
    }
}
