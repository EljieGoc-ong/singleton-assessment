using System;

namespace Patterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Kettle electricKettle = Kettle.ElectricKettleGet();

            electricKettle.Fill();
            electricKettle.Boil();
            electricKettle.Drain();

            Console.ReadLine();
        }
    }
}
