using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourcesManagement.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            CompanyDbContext context = app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<CompanyDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee {
                        Name = "Ayla Holland",
                        Address = "8 Fleet Street",
                        DOB = DateTime.Parse("06/19/1998"),
                        Department = "Human Resources"
                    },
                    new Employee {
                        Name = "Tami Saylor",
                        Address = "6 Elm Street",
                        DOB = DateTime.Parse("12/23/1997"),
                        Department = "Sales"
                    },
                    new Employee {
                        Name = "Max Padd",
                        Address = "21 Jump Street",
                        DOB = DateTime.Parse("04/20/1993"),
                        Department = "Marketing"
                    },
                    new Employee {
                        Name = "Dominique Cus",
                        Address = "42 Imperial Street",
                        DOB = DateTime.Parse("08/26/1994"),
                        Department = "Sales"
                    },
                    new Employee {
                        Name = "Herman Mellvile",
                        Address = "8 Oceanic Street",
                        DOB = DateTime.Parse("11/27/1998"),
                        Department = "Marketing"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
