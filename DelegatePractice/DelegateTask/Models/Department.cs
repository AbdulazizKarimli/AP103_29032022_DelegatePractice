using DelegateTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTask.Models
{
    internal class Department
    {
        public int EmployeeLimit { get; set; }
        private List<Employee> _employees;

        public Department(int employeeLimit)
        {
            EmployeeLimit = employeeLimit;
            _employees = new List<Employee>();
        }

        private bool IsExistsEmployee(Predicate<Employee> predicate)
        {
            Employee employee = _employees.Find(predicate); //tapilsa employee qaytarir tapilmasa null qaytarir
            if(employee == null)
                return false;

            return true;
        }
        public void AddEmployee(Employee employee)
        {
            if (IsExistsEmployee(e => e.Email == employee.Email))
                throw new EmployeeAlreadyExistsException("BU EMAILDA ISHCI VAR");

            if(_employees.Count < EmployeeLimit)
            {
                _employees.Add(employee);
                return;
            }

            throw new CapacityLimitException("limit doldu");
        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employeesCopy = new List<Employee>();
            employeesCopy.AddRange(_employees);

            return employeesCopy;
        }
        public List<Employee> FilterEmployeesBySalary(double minSalary, double maxSalary)
        {
            return _employees.FindAll(e => e.Salary >= minSalary && e.Salary <= maxSalary);

            //List<Employee> filteredEmployees = new List<Employee>();
            //foreach (var employee in _employees)
            //{
            //    if(employee.Salary >= minSalary && employee.Salary <= maxSalary)
            //    {
            //        filteredEmployees.Add(employee);
            //    }    
            //}

            //return filteredEmployees;
        }
        public Employee GetEmployeeById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null ola bilmez");

            Employee employee = _employees.Find(e => e.Id == id);

            return employee;
        }
        public void DeleteEmployeeById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null ola bilmez");

            Employee employee = _employees.Find(e => e.Id == id);
            if (employee == null)
                throw new NotFoundException("bele bir ishci yoxdur");

            _employees.Remove(employee);
        }
        public void EditEmployeeEmail(int? id, string email)
        {
            if (id == null || string.IsNullOrWhiteSpace(email))
                throw new NullReferenceException("id ve email null ola bilmez");

            Employee employee = _employees.Find(e => e.Id == id);
            if(employee == null)
                throw new NotFoundException("bele bir ishci yoxdur");

            employee.Email = email;
        }
    }
}
