﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    class PizzeriaA : Factory
    {
        protected override Pizza Create(string type)
        {
            Pizza pizza;
            IFactoryIngredients ingredients = new PizzaAIngredients();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredients) { Name = "Pizzeria A Style Cheese" };
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredients) { Name = "Pizzeria A Style Clam" };
            }
            else
            {
                pizza = new VeggiePizza(ingredients) { Name = "Pizzeria A Style Veggie" };
            }
            pizza.Color = "red";
            return pizza;
        }
    }
}
