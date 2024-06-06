using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderSystem.Models;
using System;
using System.Linq;

namespace OrderSystem.Data
{
    public static class DataInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OrderSystemContext(serviceProvider.GetRequiredService<DbContextOptions<OrderSystemContext>>()))
            {
                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new Admin { Name = "Admin", Username = "admin", Password = "admin" },
                        new Planner { Name = "Planlægger", Username = "planner", Password = "123456" },
                        new Operator { Name = "Operatør", Username = "operator", Password = "123456" },
                        new Customer { Name = "Kunde", Username = "customer", Password = "123456" }
                    );
                    context.SaveChanges();
                }

                if (!context.Machines.Any())
                {
                    context.Machines.AddRange(
                        new Machine { Name = "Maskine 1", Type = "Type 1", ManufacturingYear = 2020 },
                        new Machine { Name = "Maskine 2", Type = "Type 2", ManufacturingYear = 2020 }
                    );
                    context.SaveChanges();
                }

                //if (!context.Orders.Any())
                //{
                //    context.Orders.AddRange(
                //        new Order
                //        {
                //            Name = "Order 1",
                //            Description = "Description 1",
                //            CreatedBy = 1,
                //            CreatedAt = new DateTime(2020, 1, 1),
                //            StartDate = new DateTime(2020, 1, 2),
                //            EndDate = new DateTime(2020, 1, 3),
                //            LastEdit = new DateTime(2020, 1, 3),
                //            StartedBy = 1,
                //            EndedBy = 1,
                //            LastEditBy = 1,
                //            Status = "Status 1",
                //            Machine = 1
                //        },
                //        new Order
                //        {
                //            Name = "Order 2",
                //            Description = "Description 2",
                //            CreatedBy = 1,
                //            CreatedAt = new DateTime(2020, 1, 4),
                //            StartDate = new DateTime(2020, 1, 5),
                //            EndDate = new DateTime(2020, 1, 6),
                //            LastEdit = new DateTime(2020, 1, 6),
                //            StartedBy = 1,
                //            EndedBy = 1,
                //            LastEditBy = 1,
                //            Status = "Status 2",
                //            Machine = 2
                //        }
                //    );
                //    context.SaveChanges();
                //}
            }
        }
    }
}
