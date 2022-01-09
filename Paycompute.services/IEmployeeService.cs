using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Services
{
    public interface IEmployeeService
    {
        Task CreateAsync(Employee newEmployee);
        Employee GetById(int employeeId);
        Task UpdateAsync(Employee employee);
        Task Delete(int EmployeeId);
        decimal UnionFees(int id);
        decimal StudentLoanRepaymentAmount(int id, decimal totalAmount);
        IEnumerable<Employee> GetAll();
        Task UpdateAsync(int id);

    }
}
