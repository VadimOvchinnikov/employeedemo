using System;

namespace EmployeeDemo.DAL.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string JobTitle { get; set; }

        public DateTime EmploymentDate { get; set; }

        public decimal Rate { get; set; }

        public bool IsActive { get; set; } = true;
    }
}