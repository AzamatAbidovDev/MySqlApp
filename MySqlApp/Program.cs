using MySqlApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace MySqlApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            using (GoogleDB db = new GoogleDB())
            {
                //db.Database.EnsureDeleted();
                //db.Database.EnsureCreated();


                DateTime dateTime = new DateTime(2022, 09, 09, 11, 00, 00);
                DateTime dateTime1 = new DateTime(2022, 09, 09, 12, 00, 00);
                DateTime dateTime2 = new DateTime(2022, 09, 09, 14, 00, 00);
                

                //TimeLog time = new TimeLog
                //{ EmployeeID = 1, Hours = 8, DateCame = dateTime1, DateLeave = dateTime4 };
                //TimeLog time1 = new TimeLog
                //{ EmployeeID = 2, Hours = 8, DateCame = dateTime, DateLeave = dateTime4 };
                //TimeLog time2 = new TimeLog
                //{ EmployeeID = 3, Hours = 7, DateCame = dateTime2, DateLeave = dateTime4 };
                //TimeLog time3 = new TimeLog
                //{ EmployeeID = 4, Hours = 7, DateCame = dateTime8, DateLeave = dateTime8 };
                //TimeLog time4 = new TimeLog
                //{ EmployeeID = 5, Hours = 7, DateCame = dateTime2, DateLeave = dateTime4 };

                //TimeLog log = db.Timelogs.Where(p => p.ID == 16).First();
                //if (log != null)
                //{
                //    log.DateLeave = dateTime4;
                //    db.Timelogs.Update(log);
                //    db.SaveChanges();
                //}

                var emr = from n in db.Timelogs
                          join u in db.Employees on n.EmployeeID equals u.ID
                          where n.EmployeeID == 2
                          select new
                          {
                              id = u.ID,
                              name = u.Name,
                              time = n.DateCame,
                              time1 = n.DateLeave,
                              hour = n.Hours
                          };

                foreach (var item in emr)
                {
                    Console.WriteLine($"{item.id}.{item.name} - " +
                        $"{item.time:g}-{item.time1:t}\t ({item.hour} hours)");
                }

                int sum = db.Timelogs.Where(u => u.EmployeeID == 2).Sum(p => p.Hours);
                double srednee = db.Timelogs.Where(u => u.EmployeeID == 2).Average(p => p.Hours);

                Console.WriteLine();
                Console.WriteLine($"Total working hours = {sum} hours");
                Console.WriteLine($"Average of working hours = {srednee} hours");

            }
            Console.ReadLine();
        }
    }

}
