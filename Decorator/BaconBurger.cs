using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class BaconBurger : BurgerDecorator
    {
        public BaconBurger(Burger burger) : base(burger.Name + "с беконом", burger)
        { }

        public override int GetCost()
        {
            return burger.GetCost() + 30;
        }
    }
}
