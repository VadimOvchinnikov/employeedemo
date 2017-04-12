using EmployeeDemo.DAL.Abstract;
using EmployeeDemo.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDemo.DAL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context = new EmployeeDbContext();

        public IEnumerable<Employee> Get()
        {
            return _context.Employees
                .Where(e => e.IsActive)
                .AsEnumerable();
        }

        public void Create(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Delete(int employeeId)
        {
            Employee employee = _context.Employees.FirstOrDefault(_ => _.Id == employeeId);
            if (employee == null) return;
            // Performing "soft" delete
            employee.IsActive = false;
            _context.SaveChanges();
        }
    }
}