using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    abstract class Factory
    {
        protected abstract Pizza Create(string type);
        public Pizza Order(string type)
        {
            var pizza = Create(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

    }
}
