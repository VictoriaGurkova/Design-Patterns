using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class CheeseBurger : Burger
    {
        public CheeseBurger() : base("Чизбургер ")
        { }

        public override int GetCost()
        {
            return 50;  
        }
    }
}
