using CommonLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IuserRL
    {
        IList<EmployeeContract> GetAllEmployee();
        int AddEmployee(EmployeeContract employeeContract);
        int UpdateEmployee(EmployeeContract employeeContract, int Id);
        EmployeeContract GetById(int Id);
        int DeleteEmployee(int Id);
    }
}
