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
            int powerBase = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{powerBase}! = {Power(powerBase)}");
            Console.ReadLine();
        }

        static double Power(int powerBase)
        {
            double power = 1;
            for (int i = 2; i <= powerBase; i++)
            {
                power = power * i;
            }
            return power;
        }
    }
}