using BussinessLayer.Interfaces;
using CommonLayer.Contracts;
using RepositoryLayer.Interfaces;
using RepositoryLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Services
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepository userRL;

        public EmployeeBusiness()
        {
            userRL = new EmployeeRepository();
        }
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employeeContract">The employee contract.</param>
        /// <returns></returns>
        public string AddEmployee(EmployeeContract employeeContract)
        {
            if (userRL.AddEmployee(employeeContract) == 1)
            {
                return "employee added sucessfully";
            }
            else
            {
                return "Employee not added";
            }
        }
        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        public string DeleteEmployee(int Id)
        {
            if (userRL.DeleteEmployee(Id) == 1)
            {
                return "Employee deleted successfuly";
            }
            else
            {
                return "Employee does not exists.";
            }
        }
        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns></returns>
        public IList<EmployeeContract> GetAllEmployee()
        {
            IList<EmployeeContract> employeeContracts = userRL.GetAllEmployee();
            if (employeeContracts != null)
            {
                return employeeContracts;
            }
            else
            {
                return new List<EmployeeContract>();
            }
        }
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        public EmployeeContract GetById(int Id)
        {
            EmployeeContract employeeContract = userRL.GetById(Id);
            if (employeeContract != null)
            {
                return employeeContract;
            }
            else
            {
                return new EmployeeContract();
            }
        }
        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeContract">The employee contract.</param>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        public string UpdateEmployee(EmployeeContract employeeContract, int Id)
        {
            if (userRL.UpdateEmployee(employeeContract, Id) == 1)
            {
                return "Employee updated successfully";
            }
            else
            {
                return "Employee not updated";
            }
        }
    }
}