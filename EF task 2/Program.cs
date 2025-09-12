using EF_Task_1.Contexts;
using EF_Task_1.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext context = new CompanyDbContext();
            #region Add
            //Employee employee = new Employee
            //{
            //    Name = "Ahmed",
            //    Address ="Cairo",
            //    Age = 25,
            //    Email = "ahmed@gmail.com",
            //    test=10
            //};
            //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //Console.WriteLine(context.Entry(employee).State);
            //context.Add(employee);
            //Console.WriteLine(context.Entry(employee).State);
            //Console.WriteLine($"Employee Id is {employee.Id} Before Saving");
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(employee).State);
            //Console.WriteLine($"Employee Id is {employee.Id} After Saving");
            #endregion

            #region Retrieve
            //var employee = context.Employees.Where(employee => employee.Id == 1).FirstOrDefault();
            //var employee = context.Employees.FirstOrDefault(employee => employee.Id == 1);
            //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //var employee = context.Employees.AsNoTracking().FirstOrDefault(employee => employee.Id == 1);
            //if (employee is not  null )
            //{
            //    Console.WriteLine(context.Entry(employee).State);
            //    Console.WriteLine(employee.Name);
            //}



            #endregion

            #region Update
            //var employee = context.Employees.FirstOrDefault(employee => employee.Id == 1);
            //if (employee is not null)
            //{
            //    Console.WriteLine(context.Entry(employee).State);
            //    Console.WriteLine(employee.Name);
            //    employee.Name = "Hassan";
            //    Console.WriteLine(context.Entry(employee).State);
            //    Console.WriteLine(employee.Name);
            //    context.SaveChanges();
            //    Console.WriteLine(context.Entry(employee).State);
            //    Console.WriteLine(employee.Name);

            //}
            #endregion

            #region Delete
            //var employee = context.Employees.FirstOrDefault(employee => employee.Id == 1);
            //if (employee is not null)
            //{
            //    Console.WriteLine(context.Entry(employee).State);
            //    context.Remove(employee);
            //    Console.WriteLine(context.Entry(employee).State);

            //    context.SaveChanges();
            //    Console.WriteLine(context.Entry(employee).State);

            //}
            #endregion


        }
    }
}
