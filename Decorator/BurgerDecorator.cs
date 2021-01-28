using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class BurgerDecorator : Burger
    {
        protected Burger burger;
        public BurgerDecorator(string name, Burger burger) : base(name)
        {
            this.burger = burger;
        }
    }
}
