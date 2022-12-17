using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcWeb.Models;
using System;
using System.Linq;
using MvcWeb.Data;





namespace MvcWeb.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcWebContext(
             serviceProvider.GetRequiredService<
                 DbContextOptions<MvcWebContext>>())) {



                if (context.Employee.Any())
                {
                    return;
                }


                var employee = new Employee[]
                {
                new Employee
                {
                    EmployeeID="EM001",
                    EmployeeName="Jond Carter",
                    Department="HR",
                    Salary= 3000
                },
                new Employee
                {
                    EmployeeID="EM002",
                    EmployeeName="Michael Bean",
                    Department="SC",
                    Salary= 1300
                },
                new Employee
                {
                    EmployeeID="EM003",
                    EmployeeName="Jimmy Floy",
                    Department="MD",
                    Salary= 2000
                },
                new Employee
                {
                    EmployeeID="EM004",
                    EmployeeName="Mary Brown",
                    Department="MD",
                    Salary= 2000
                }

                };

                context.SaveChanges();


            }



        }
    }
}
