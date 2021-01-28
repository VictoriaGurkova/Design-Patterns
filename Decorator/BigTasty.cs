using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class BigTasty : Burger
    {
        public BigTasty() : base("Биг Тейсти ")
        { }

        public override int GetCost()
        {
            return 249;
        }
    }
}
