using System.Collections.Generic;
using System.Web.Http;
using EmployeeDemo.DAL.Abstract;
using EmployeeDemo.DAL.Models;
using Ninject;

namespace EmployeeDemo.WebUI.Controllers
{
    public class EmployeesController : ApiController
    {
        [Inject]
        public IEmployeeRepository EmployeeRepository { get; set; }

        // GET api/<controller>
        public IEnumerable<Employee> Get()
        {
            return EmployeeRepository.Get();
        }

        // POST api/<controller>
        public void Post(Employee employee)
        {
            EmployeeRepository.Create(employee);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            EmployeeRepository.Delete(id);
        }
    }
}