using EmployeeManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagement
{
    class ManagerEmployee
    {
        private List<Employee> _employees;
        

        public ManagerEmployee()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public string GetAllEmployeeInfo()
        {
            string result = "";
            foreach (var o in _employees)
            {
                result = result + o.ToString();
            }
            return result;
        }

        public bool RemoveEmployeeById(string id)
        {
            Employee employeeInList = _employees.FirstOrDefault(epls => epls.id.Equals(id));
            if (employeeInList != null)
            {
                _employees.Remove(employeeInList);
                return true;
            }
            else return false;
        }
        public bool CheckIdOfEmployees(string id)
        {
            Employee employeeInList = _employees.FirstOrDefault(x => x.id.Equals(id));
            if (employeeInList == null)
            {
                return false;
            }
            return true;
        }
        public bool UpdateEngineerById(string id, string name, int age, string gender,
            string address, string branch)
        {
            Engineer engineerInList = (Engineer)_employees.FirstOrDefault(u => u.id.Equals(id));
            if (engineerInList == null) return false;
            engineerInList.id = id;
            engineerInList.name = name;
            engineerInList.age = age;
            engineerInList.gender = gender;
            engineerInList.address = address;
            engineerInList.branch = branch;
            return true;
        }
        public bool UpdateWorkerById(string id, string name, int age, string gender,
            string address, int level)
        {
            Worker workerInList = (Worker)_employees.FirstOrDefault(u => u.id.Equals(id));
            if (workerInList == null) return false;
            workerInList.id = id;
            workerInList.name = name;
            workerInList.age = age;
            workerInList.gender = gender;
            workerInList.address = address;
            workerInList.level = level;
            return true;
        }
    }
}
