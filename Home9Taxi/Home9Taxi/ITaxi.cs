using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9Taxi
{
    internal interface ITaxi
    {
        void MakeRide(in User user);
        double GetPriceOfRide();
    }
}
