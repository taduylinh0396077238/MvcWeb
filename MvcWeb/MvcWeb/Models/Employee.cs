using System;
using System.Collections.Generic;

namespace MvcWeb.Models
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public int  Salary { get; set; }

        //public ICollection<Enrollment> Enrollments { get; set; }
    }
}