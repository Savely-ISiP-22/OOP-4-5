using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee : Person
    {
        private string company;

        public Employee(string name, string surname, string comp) 
            : base(name, surname)
        {
            company = comp;
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public void DisplayE()
        {
            Console.WriteLine(Name + " | " + Surname + " | " + Company);
        }
    }
}
