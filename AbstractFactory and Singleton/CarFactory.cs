using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    abstract public class CarFactory
    {
        abstract public Motor CreateMotor();

        abstract public Underframe CreateUnderframe();

        abstract public Bulk CreateBulk();
    }
}
