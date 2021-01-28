using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class TripleBurger : BurgerDecorator
    {
        public TripleBurger(Burger burger) : base(burger.Name + "Тройной", burger)
        { }

        public override int GetCost()
        {
            return burger.GetCost() + 119;
        }
    }
}
