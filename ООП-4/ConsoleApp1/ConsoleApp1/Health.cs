using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Health
    {
        public int temperature;
        public int Temp
        {
            get
            {
                return temperature;
            }

            set
            {
                if ((value >= 34) && (value <= 41))
                    {
                        temperature = value;
                    }

                else
                    {
                        temperature = 34;
                        Console.WriteLine("Значение находится вне диапозона, поэтому присвоено минимальное значение"); 
                    }
            }
        }
    }
}
