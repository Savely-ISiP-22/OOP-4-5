using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Health health = new Health();

        health:
            Console.WriteLine("Введите температуру тела от 34 до 41");

            try
            {
                health.Temp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Температура тела - " + health.Temp);
            }
            catch
            {
                Console.WriteLine("Неккорректный тип данных");
                goto health;
            }

            Console.WriteLine("");


            Book book = new Book();

        book:
            Console.WriteLine("Введите год выпуска от 1940 до 2020");

            try
            {

                book.ReleaseYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Год выпуска - " + book.ReleaseYear);

            }
            catch
            {
                Console.WriteLine("Неккорректный тип данных");

            }
            goto book;

            Console.ReadKey();
        }
    }
}
