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
            Console.WriteLine("Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());
            string operation;

            do
            {
                Console.WriteLine("Jaką operację chcesz wykonać (+ | - | * | /) lub wciśnij \"n\" aby zakończyć program ");
                operation = Console.ReadLine();

                if (operation == "n")
                {
                    Console.WriteLine("Twój wynik to: " + a);
                    break;
                }

                Console.WriteLine("Podaj liczbę: ");
                int b = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case "+":
                        a = a + b;
                        break;
                    case "-":
                        a = a - b;
                        break;
                    case "*":
                        a = a * b;
                        break;
                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("Nie wolno dzielić przez 0");
                        }
                        else
                        {
                            a = a / b;
                        }
                        break;
                    default:
                        Console.WriteLine("Nieznana operacja!");
                        break;
                }
            } while (operation != "n");

            Console.ReadLine();
        }
    }
}