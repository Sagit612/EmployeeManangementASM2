using EmployeeManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    class Engineer : Employee
    {
        public string branch;
        public Engineer()
        {
        }

        public Engineer(string id, string name, int age, string gender, string address, string branch)
            : base(id, name, age, gender, address)
        {
            this.branch = branch;
        }

        public override string ToString()
        {
            string result = $"Engineer --- ID: {id} | Full Name: {name} | Age: {age} | " +
                $"Gender: {gender} | Address: {address} | Branch: {branch} \n";
            return result;
        }
    }
}
