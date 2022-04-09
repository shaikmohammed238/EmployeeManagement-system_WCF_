using CommonLayer.Contracts;
using RepositoryLayer.Interfaces;
using RepositoryLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        EmployeeManagemnt_WCFEntities employeeManagemnt_WCF;

        public EmployeeRepository()
        {
            employeeManagemnt_WCF = new EmployeeManagemnt_WCFEntities();
        }
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employeeContract">The employee contract.</param>
        /// <returns></returns>
        public int AddEmployee(EmployeeContract employeeContract)
        {

            EmployeeManagemnt emp = new EmployeeManagemnt()
            {
                Name = employeeContract.Name,
                Salary = employeeContract.Salary,
                Email = employeeContract.Email
            };
            employeeManagemnt_WCF.EmployeeManagemnts.Add(emp);
            return employeeManagemnt_WCF.SaveChanges();
        }
        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        public int DeleteEmployee(int Id)
        {
            var employee = (from a in employeeManagemnt_WCF.EmployeeManagemnts
                            where a.Id == Id
                            select a).FirstOrDefault();
            if (employee != null)
            {
                employeeManagemnt_WCF.EmployeeManagemnts.Remove(employee);
                return employeeManagemnt_WCF.SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns></returns>
        public IList<EmployeeContract> GetAllEmployee()
        {
            var query = (from a in employeeManagemnt_WCF.EmployeeManagemnts select a).Distinct();
            List<EmployeeContract> employeeData = new List<EmployeeContract>();

            query.ToList().ForEach(x =>
            {
                employeeData.Add(new EmployeeContract
                {
                    Id = x.Id,
                    Name = x.Name,
                    Salary = (int)x.Salary,
                    Email = x.Email
                });
            });
            return employeeData;
        }
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        public EmployeeContract GetById(int Id)
        {
            var Employee = employeeManagemnt_WCF.EmployeeManagemnts.Find(Id);
            EmployeeContract employeeContract = new EmployeeContract()
            {
                Name = Employee.Name,
                Email = Employee.Email,
                Salary = (int)Employee.Salary,
                Id = Employee.Id
            };
            return employeeContract;
        }
        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeContract">The employee contract.</param>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">Employee do not exists</exception>
        public int UpdateEmployee(EmployeeContract employeeContract, int Id)
        {
            EmployeeManagemnt employee = employeeManagemnt_WCF
               .EmployeeManagemnts.Find(Id);
            if (employee != null)
            {
                employee.Email = employeeContract.Email;
                employee.Name = employeeContract.Name;
                employee.Salary = employeeContract.Salary;

                return employeeManagemnt_WCF.SaveChanges();
            }
            else
            {
                throw new Exception("Employee do not exists");
            }
        }
    }
}
