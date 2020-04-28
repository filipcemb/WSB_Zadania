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

            Console.WriteLine("Jaką operację chcesz wykonać (+ | - | * | /): ");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Nie wolno dzielić przez 0");
                    }
                    else
                    {
                        Console.WriteLine(a / b);
                    }
                    break;
                default:
                    Console.WriteLine("Nieznana operacja!");
                    break;
            }
            Console.ReadLine();
        }
    }
}