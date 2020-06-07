using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    class Health
    {
        public int temperature;
        public int Temperature
        {
            set 
            {
                if (value < 34) {
                    Console.WriteLine("Значение меньше диапозона - присвоено минимальное значение");
                    temperature = 34;
                }
                else
                if (value > 41) {
                    Console.WriteLine("Значение больше диапозона - присвоено максимальное значение");
                    temperature = 41;
                }
                else temperature = value;
            }
            get 
            {  
                return temperature;  
            }
        }
    }

    class Book
    {
        private int year;
        public int Year
        {
            set
            {

                if (value < 1940) {
                    Console.WriteLine("Значение меньше диапозона - присвоено минимальное значение");
                    year = 1940;
                }

                else
                if (value > 2020)  {
                    Console.WriteLine("Значение больше диапозона - присвоено максимальное значение");
                    year = 2020;
                }
                else year = value;
            }
            get
            {
                return year;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Health health = new Health();

            int cikl = 0;
            while (cikl == 0)
            { 
                Console.WriteLine("Введите температуру от 34 до 41");
                try {
                  health.Temperature = Convert.ToInt32(Console.ReadLine()); break;
                }
                catch { 
                  Console.WriteLine("Пожалуйста, введите 'число'"); 
                }
            }
            Console.WriteLine("t= " + health.Temperature);
            Console.WriteLine("------------------------------------");


            Book book = new Book();

            while (cikl == 0) 
            { 
                Console.WriteLine("Введите год выпуска от 1940 до 2020");
                try  { 
                    book.Year = Convert.ToInt32(Console.ReadLine()); break;
                }
                catch { 
                    Console.WriteLine("Пожалуйста, введите 'число'"); 
                }
            }
            Console.WriteLine("Год выпуска: " + book.Year);
            Console.WriteLine("------------------------------------");

            Console.ReadKey();
        }
    }
}
