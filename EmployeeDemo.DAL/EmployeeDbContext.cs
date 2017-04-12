using EmployeeDemo.DAL.Models;
using System.Data.Entity;

namespace EmployeeDemo.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}