using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter: ServerInterface
    {
        private Server server;

        public Adapter()
        {
            server = new Server();
        }

        public double GetTemperature()
        {
            double temp = server.GetTemperature();
            return (temp - 32) / 1.8;
        }
    }
}
