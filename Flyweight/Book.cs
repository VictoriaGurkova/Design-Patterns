using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    abstract class Book
    {
        protected string name;
        protected string author;

        public abstract void Produce(string binding, string font, string paper, string cover);
    }
}
