using BussinessLayer.Interfaces;
using BussinessLayer.Services;
using CommonLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeMnagement_WCF_
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeBusiness userBL;
        public EmployeeService()
        {
            userBL = new EmployeeBusiness();
        }
        public string AddEmployee(EmployeeContract employeeContract)
        {
            try
            {
                return userBL.AddEmployee(employeeContract);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public EmployeeContract GetById(string Id)
        {
            int empId = Convert.ToInt32(Id);
            return userBL.GetById(empId);
        }

        public IList<EmployeeContract> GetAllEmployees()
        {
            return userBL.GetAllEmployee();
        }

        public string UpdateEmployee(EmployeeContract employeeContract, string Id)
        {
            int empId = Convert.ToInt32(Id);
            return userBL.UpdateEmployee(employeeContract, empId);
        }

        public string DeleteEmployee(string Id)
        {
            int empId = Convert.ToInt32(Id);
            return userBL.DeleteEmployee(empId);
        }
    }
}
