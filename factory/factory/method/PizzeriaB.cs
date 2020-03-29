using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    class PizzeriaB : Factory
    {
        protected override Pizza Create(string type)
        {
            Pizza pizza;
            IFactoryIngredients ingredients = new PizzaBIngredients();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredients);
                pizza.Name = "Pizzeria B Cheese";
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredients);
                pizza.Name = "Pizzeria B Clam";
            }
            else
            {
                pizza = new VeggiePizza(ingredients);
                pizza.Name = "Pizzeria B Veggie";
            }
            pizza.Color = "green";
            return pizza;
        }
    }
}
