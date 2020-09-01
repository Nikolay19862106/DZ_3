using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, которое хотите возвести в степень");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень");
            int stepen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{x}^{stepen} = " + Math.Pow(x, stepen));
            Console.ReadKey();
        }
    }
}

