using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_loops_instead
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNum = new Random();
            var total = 0;

            for (var i = 0; i < 3; i++)
            {
                var rolled = randomNum.Next(1, 7);
                Console.WriteLine($"1d6: {rolled}");                
                total += rolled;
            }
            for (var i = 0; i < 2; i++)
            {
                var rolled = randomNum.Next(1, 9);
                Console.WriteLine($"1d8:   {rolled}");
                total += rolled;
            }
            Console.WriteLine();
            Console.WriteLine($"Roll total: {total}");
            Console.WriteLine();
            Console.Write("> ");
            Console.ReadLine();
        }
    }
}
