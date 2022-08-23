using System.Reflection;

namespace Home12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();

            try
            {
                employee.Name = "Ilya";
                employee.Age = 20;
                employee.Salary = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Type type = employee.GetType();

            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                var prop = type.GetProperty(propertyInfo.Name);
                Console.WriteLine($"{propertyInfo.Name} -- {prop?.GetValue(employee)}");
            }
        }
    }
}