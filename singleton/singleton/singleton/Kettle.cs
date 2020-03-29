using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Patterns.Singleton
{
    public class Kettle
    {
        private static readonly Kettle Instance = new Kettle();

        public static Kettle ElectricKettleGet()
        {
            Console.WriteLine("Starting");
            return Instance;
        }

        public void Fill()
        {
            Console.WriteLine("Filling...");
        }

        public void Drain()
        {
            Console.WriteLine("Draining...");
        }

        public void Boil()
        {
            Console.WriteLine("Boiling...");
        }
    }
}
