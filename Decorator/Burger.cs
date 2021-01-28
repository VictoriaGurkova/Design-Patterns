using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class Burger
    {
        public Burger(string name)
        {
            this.Name = name;
        }

        public string Name { get; protected set; }
        public abstract int GetCost();
    }
}
