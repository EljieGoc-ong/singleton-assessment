﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    abstract class Pizza
    {
        public string Color;

        internal abstract void Prepare();
        internal void Bake()
        {
            Console.WriteLine("Baking at 135 degree Celsius for 25 minutes");
        }
        internal void Cut()
        {
            Console.WriteLine("Cutting into diagonal pieces");
        }
        internal void Box()
        {
            Console.WriteLine("Putting pizza in " + Color + " coloured box");
        }

        public string Name { protected get; set; }

    }
}