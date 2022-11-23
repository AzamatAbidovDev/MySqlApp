using System;
using System.ComponentModel.DataAnnotations;

namespace MySqlApp.Entities
{
    public class TimeLog
    {
        [Key]
        public int ID { get; set; }
        public DateTime DateCame { get; set; }
        public DateTime DateLeave { get; set; }
        public int EmployeeID { get; set; }
        public int Hours { get; set; }
    }
}
