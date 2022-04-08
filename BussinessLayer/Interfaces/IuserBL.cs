using CommonLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    public interface IuserBL
    {
        IList<EmployeeContract> GetAllEmployee();
        string AddEmployee(EmployeeContract employeeContract);
        string UpdateEmployee(EmployeeContract employeeContract, int Id);
        EmployeeContract GetById(int Id);
        string DeleteEmployee(int Id);
    }
}
