using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Book
    {
        private int releaseYear;
        public int ReleaseYear
        {
            get
            {
                return releaseYear;
            }

            set
            {
                if ((value >= 1940) && (value <= 2020))
                    {
                        releaseYear = value;
                    }

                else
                    {
                        releaseYear = 1940;
                        Console.WriteLine("Значение находится вне диапозона, поэтому присвоено минимальное значение");
                    }
            }
        }
    }
}
