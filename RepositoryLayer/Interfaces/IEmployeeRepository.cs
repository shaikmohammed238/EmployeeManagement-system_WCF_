using CommonLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IEmployeeRepository
    {
        IList<EmployeeContract> GetAllEmployee();
        int AddEmployee(EmployeeContract employeeContract);
        int UpdateEmployee(EmployeeContract employeeContract, int Id);
        EmployeeContract GetById(int Id);
        int DeleteEmployee(int Id);
        EmployeeContract GetByName(string Name);
    }
}
