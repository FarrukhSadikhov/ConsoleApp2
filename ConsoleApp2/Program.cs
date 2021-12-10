using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти площадь круга");
            Console.Write("Введите данные круга:");
            int r = Convert.ToInt16(Console.ReadLine());
            double perimetr = 2 * 3.14 * r;
            double ploshad = 3.14 * r * r;
            Console.WriteLine($"периметр: {perimetr} , площадь: {ploshad}");
            Console.ReadKey();


        }
    }
}   
