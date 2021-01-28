using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class DoubleBurger : BurgerDecorator
    {
        public DoubleBurger(Burger burger) : base(burger.Name + "Двойной", burger)
        { }

        public override int GetCost()
        {
            return burger.GetCost() + 75;
        }
    }

}
