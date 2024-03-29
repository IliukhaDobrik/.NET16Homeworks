﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home10
{

    internal class Employee
    {
        
        private int _age = 0;
        private int _expirience = 0;
        public string Name { get; set; } = string.Empty;
        public bool IsHigherEducation { get; set; } = false;
        public int Salary { get; private set; } = 0;
        public int Age 
        {
            get => _age;
            set
            {
                if (value < 0 || value > 120)
                {
                    _age = 0;
                }

                _age = value;
            } 
        }
        public int Experience 
        {
            get => _expirience;
            set
            {
                if (value < 0)
                {
                    _expirience = 0;
                }

                _expirience = value;
            }
        }
       
        public static void ShowSalary(List<Employee> employees)
        {
            Console.WriteLine("***Without delegate***");

            foreach (var employee in employees)
            {
                if (employee.IsHigherEducation)
                {
                    employee.Salary = (employee.Experience + 1) * 1250;
                }
                else
                {
                    employee.Salary = (employee.Experience + 1) * 1000;
                }
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} -- {employee.Salary}$");
            }

            Console.WriteLine();
        }

        public static void ShowSalary(List<Employee> employees, Program.MyDelegate myDelegate)
        {
            Console.WriteLine("***With delegate***");

            foreach (var employee in employees)
            {
                employee.Salary = myDelegate(employee);
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} -- {employee.Salary}$");
            }

            Console.WriteLine();
        }
    }
}
