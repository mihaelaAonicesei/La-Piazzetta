using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace La_Piazzetta.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public DateTime EmploymentEndDate { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
    }
}