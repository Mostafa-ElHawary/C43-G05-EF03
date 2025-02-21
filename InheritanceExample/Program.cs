using InheritanceExample.Context;
using InheritanceExample.Entities;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 WAYS To Generate schema
            // TPC 
            // TPH
            // TPCC
            static void Main(string[] args)
            {

                using AppDpContext context = new AppDpContext();

                FullTimeEmployees fullTime = new FullTimeEmployees()
                {
                    Name = "Ali",
                    Position = "Hr",
                    Salary = 100000,
                };
                FullTimeEmployees fullTime2 = new FullTimeEmployees()
                {
                    Name = "Sara",
                    Position = "Developer",
                    Salary = 120000,
                };

                FullTimeEmployees fullTime3 = new FullTimeEmployees()
                {
                    Name = "Mona",
                    Position = "Manager",
                    Salary = 150000,
                };

                FullTimeEmployees fullTime4 = new FullTimeEmployees()
                {
                    Name = "Emma",
                    Position = "Designer",
                    Salary = 90000,
                };

                context.FullTimeEmployees.Add(fullTime);
                context.FullTimeEmployees.Add(fullTime2);
                context.FullTimeEmployees.Add(fullTime3);
                context.FullTimeEmployees.Add(fullTime4);

                PartTimeEmployees partTime1 = new PartTimeEmployees()
                {
                    Name = "Tom",
                    Position = "Support",
                    HourlyRate = 50,
                };

                PartTimeEmployees partTime2 = new PartTimeEmployees()
                {
                    Name = "Jerry",
                    Position = "Tester",
                    HourlyRate = 60,
                };

                PartTimeEmployees partTime3 = new PartTimeEmployees()
                {
                    Name = "Anna",
                    Position = "Intern",
                    HourlyRate = 30,
                };

                PartTimeEmployees partTime4 = new PartTimeEmployees()
                {
                    Name = "Lucy",
                    Position = "Consultant",
                    HourlyRate = 80,
                };

                context.PartTimeEmployees.Add(partTime1);
                context.PartTimeEmployees.Add(partTime2);
                context.PartTimeEmployees.Add(partTime3);
                context.PartTimeEmployees.Add(partTime4);

                //context.Employees.Add(partTime1);
                //context.Employees.Add(partTime2);
                //context.Employees.Add(partTime3);
                //context.Employees.Add(partTime4);

                context.SaveChanges();

                //foreach (var part in context.Employees)
                //{
                //    Console.WriteLine(part.Name);
                //}
                //context.Employees.Where(e => e is PartTimeEmployees)
                //    .ToList().ForEach(e => Console.WriteLine(e.Name));

                //Note: EF Core Don't Loading Any Navigational Propery
                //EF Core Loading Navigational Propery

                // 1.Explicit Loading
                //2.Eager Loading
                //3.Lazing Loading
            }
        }

    }
}
