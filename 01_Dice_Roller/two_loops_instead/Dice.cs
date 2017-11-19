using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_loops_instead
{
    using System;

    public class Dice
    {
        public int Sides { get; }
        public string Description { get; }
        private Random random { get; } = new Random();

        public Dice(int sides, string description)
        {
            this.Sides = sides;
            this.Description = description;
        }

        public int Roll()
        {
            return this.random.Next(1, this.Sides + 1); ;
        }

    }
}
