using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Gates", "Bill");
            Employee emp = new Employee("Swith", "Tom", "Jerry");

            p.Display();
            emp.DisplayE();
            Console.ReadKey();
        }
    }
}
