using C43_G05_EF03.Context;
using C43_G05_EF03.Entities;

namespace C43_G05_EF03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

            List<Department> departments = new List<Department>
            {
                new Department { DepartmentId = 1, Name = "HR" },
                new Department { DepartmentId = 2, Name = "IT" },
                new Department { DepartmentId = 3, Name = "Finance" }
            };

            List<Employee> employees = new List<Employee>
            {
                new Employee { EmployeeId = 1, FirstName = "zidan", LastName = "Doe", DepartmentId = 1 },
                new Employee { EmployeeId = 2, FirstName = "Jane", LastName = "Smith", DepartmentId = 2 },
                new Employee { EmployeeId = 3, FirstName = "Bob", LastName = "Johnson", DepartmentId = 3 }
            };

            context.Departments.AddRange(departments);
            context.Employees.AddRange(employees);


            context.SaveChanges();

        }
    }
}
