using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    class ClamPizza : Pizza
    {
        readonly IFactoryIngredients _ingredients;

        public ClamPizza(IFactoryIngredients ingredients)
        {
            _ingredients = ingredients;
        }

        internal override void Prepare()
        {
            Console.WriteLine("Preparing " + Name + " Using");
            Console.Write("Dough: " + _ingredients.CreateDough().Name + ", Clam: " + _ingredients.CreateClam().Name + ", Sauce: " + _ingredients.CreateSauce().Name + ", Cheese: " + _ingredients.CreateCheese().Name);
            Console.WriteLine();

        }
    }
}
