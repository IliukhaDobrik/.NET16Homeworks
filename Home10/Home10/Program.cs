namespace Home10
{
    internal class Program
    {
        public delegate int MyDelegate(Employee empl);
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee(){ Name = "Ilya", Age = 20, Experience = 3, IsHigherEducation = true},
                new Employee(){ Name = "Dasha", Age = 19, Experience = 1, IsHigherEducation = true},
                new Employee(){ Name = "Dima", Age = 19, Experience = 1, IsHigherEducation = true},
                new Employee(){ Name = "Sasha", Age = 22, Experience = 7, IsHigherEducation = false},
            };

            Employee.ShowSalary(employees);
            Employee.ShowSalary(employees, CalculateSalary);
            Employee.ShowSalary(employees, CalculateSalaryWithoutDiscrimination);
            Employee.ShowSalary(employees, (Employee employee) =>
            {
                if (employee.Experience >= 3)
                {
                    return (employee.Experience + 1) * 1250;
                }
                else
                {
                    return (employee.Experience + 1) * 1000;
                }
            });
        }

        static int CalculateSalary(Employee employee)
        {
            if (employee.IsHigherEducation)
            {
                return (employee.Experience + 1) * 1250;
            }
            else
            {
                return (employee.Experience + 1) * 1000;
            }
        }

        static int CalculateSalaryWithoutDiscrimination(Employee employee)
        {
            return (employee.Experience + 1) * 1000;
        }
    }
}