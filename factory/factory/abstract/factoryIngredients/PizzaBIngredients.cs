using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class PizzaBIngredients : IFactoryIngredients
    {
        ICheese IFactoryIngredients.CreateCheese()
        {
            return new Parmesan();
        }

        IClam IFactoryIngredients.CreateClam()
        {
            return new FreshClam();
        }

        IDough IFactoryIngredients.CreateDough()
        {
            return new DeepDish();
        }

        ISauce IFactoryIngredients.CreateSauce()
        {
            return new PlumTomato();
        }

        IEnumerable<IVeggies> IFactoryIngredients.CreateVeggies()
        {
            IVeggies[] arr = { new Cucumber(), new Onion(), new BellPepper() };
            return arr;
        }
    }
}
