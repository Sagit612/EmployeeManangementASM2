using EmployeeManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    interface IEmployee
    {
        void AddOfficer(Employee officer);
        string GetAllOfficerInfo();
        bool RemoveOfficerById(int id);
        bool UpdateEngineerById(int id, string name, int age, string gender,
            string address, int branch);

        bool UpdateWorkerById(int id, string name, int age, string gender,
            string address, int level);
        int CountOfficers();
    }
}
