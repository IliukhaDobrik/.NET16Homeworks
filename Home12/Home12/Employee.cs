using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home12
{
    internal class Employee
    {
        private int _age = 0;
        private string _name = string.Empty;
        private double _salary = 0d;

        public int Age
        {
            get => _age;
            set
            {
                if (value < 18)
                {
                    throw new ArgumentException("Age less then 18!");
                }
                _age = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name is null or empty!");
                }
                if (value.Length >= 100)
                {
                    throw new ArgumentException("Your name is so long1");
                }
                _name = value;
            }
        }

        public double Salary
        {
            get => _salary;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary can't be negative!");
                }
                _salary = value;
            }
        }
    }
}
