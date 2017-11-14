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
            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();

            Dice d6 = new Dice(6);

            var total = 0;
            for (var i = 0; i < 3; i++)
            {
                var roll = d6.Roll();
                Console.WriteLine($"1d6: {roll}");                
                total += roll;
            }

            Dice d8 = new Dice(8);
            for (var i = 0; i < 2; i++)
            {
                var roll = d8.Roll();
                Console.WriteLine($"1d8:   {roll}");
                total += roll;
            }
            Console.WriteLine();
            Console.WriteLine($"Roll total: {total}");
            Console.WriteLine();
            Console.Write("> ");
            Console.ReadLine();
        }
    }
}
