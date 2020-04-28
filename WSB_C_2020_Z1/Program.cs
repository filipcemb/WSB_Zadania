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
            double power = 1;
            for (byte i = 2; i <= 9; i++)
            {
                power = power * i;
            }
            Console.WriteLine($"9! = {power}");

            power = 1;
            for (byte i = 2; i <= 12; i++)
            {
                power = power * i;
            }
            Console.WriteLine($"12! = {power}");

            power = 1;
            for (byte i = 2; i <= 20; i++)   
            {
                power = power * i;
            }
            Console.WriteLine($"20! = {power}");
            Console.ReadLine();
        }
    }
}