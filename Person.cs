using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_project_2
{
    internal class Person
    {
        protected int id { get; set; }
        protected string name  { get; set; }
        protected int age { get; set; }
        protected string email { get; set; }

        public Person(int id, string name, int age, string email)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.email = email;
        }
        public void showDetails()
        {
            // private can only be assessed in same class
            // protected can only accessed i child class due to inheritance
            // public can be accessed any where 
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("email" + email); 
        }
    }
}
