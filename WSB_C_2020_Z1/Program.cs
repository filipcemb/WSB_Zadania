using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSB_C_2020_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Twój wynik: ");
            Console.WriteLine(a * b);

            Console.ReadLine();
        }
    }
}