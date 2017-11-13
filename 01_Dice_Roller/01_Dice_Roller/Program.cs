using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Dice_Roller
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNum = new Random();

            Console.WriteLine($"1d6: { randomNum.Next(1, 7)}");
            Console.WriteLine($"1d6: { randomNum.Next(1, 7)}");
            Console.WriteLine($"1d6: { randomNum.Next(1, 7)}");
            Console.WriteLine($"1d8:    { randomNum.Next(1, 9)}");
            Console.WriteLine($"1d8:    { randomNum.Next(1, 9)}");

            Console.WriteLine();
            Console.WriteLine($"Roll total: 20");

            Console.WriteLine();
            Console.Write("> ");

            Console.ReadLine();

        }
    }
}
