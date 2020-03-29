using System;
using System.Linq;

namespace factory
{
    static class Program
    {
        static void Main(string[] args)
        {
            //*Cheese *Veggies *Clam//

            //Pizzeria A Order Veggies//
            Console.WriteLine("Pizzeria A:");
            var pizzeriaA = new PizzeriaA();
            pizzeriaA.Order("Veggies");

            //Pizzeria A Order Clam//
            Console.WriteLine("Pizzeria B:");
            var pizzeriaB = new PizzeriaB();
            pizzeriaB.Order("Clam");
        }
    }
}
