using EmployeeDemo.DAL.Models;
using System.Collections.Generic;

namespace EmployeeDemo.DAL.Abstract
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> Get();

        void Create(Employee employee);

        void Delete(int employeeId);
    }
}