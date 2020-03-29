using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class PizzaAIngredients : IFactoryIngredients
    {
        ICheese IFactoryIngredients.CreateCheese()
        {
            return new Mozarella();
        }

        IClam IFactoryIngredients.CreateClam()
        {
            return new FrozenClam();
        }

        IDough IFactoryIngredients.CreateDough()
        {
            return new ThinCrust();
        }

        ISauce IFactoryIngredients.CreateSauce()
        {
            return new CherryTomato();
        }

        IEnumerable<IVeggies> IFactoryIngredients.CreateVeggies()
        {
            IVeggies[] arr = { new Olive(), new Onion(), new BellPepper() };
            return arr;
        }
    }
}
