using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    public interface IFactoryIngredients
    {
        IDough CreateDough();
        IEnumerable<IVeggies> CreateVeggies();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IClam CreateClam();
    }
}
