using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private string surname;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public void Display()
        {
            Console.WriteLine(Name + " | " + Surname);
        }

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }
}
