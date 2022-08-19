using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home11
{
    delegate void NotifyWarmUpCompleted(string nameOfDish);
    internal class Microwave
    {
        public event NotifyWarmUpCompleted? WarmUpCompleted;

        public void WarmUp(string nameOfDish)
        {
            Console.WriteLine($"Я подогреваю {nameOfDish}");
            WarmUpCompleted?.Invoke(nameOfDish);
        }
    }
}
