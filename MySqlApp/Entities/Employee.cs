using System;
using System.ComponentModel.DataAnnotations;

namespace MySqlApp.Entities
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
    }
}
