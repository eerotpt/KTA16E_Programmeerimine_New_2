﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_loops_instead
{
    using System;

    public class Dice
    {
        public int Roll(int sides)
        {
            var random = new Random();

            return random.Next(1, sides + 1);
        }

    }
}
