using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    class Worker : Employee
    {
        public int level;
        public Worker()
        {
        }

        public Worker(string id, string name, int age, string gender, string address, int level) : base(id, name, age, gender, address)
        {
            this.level = level;
        }

        public override string ToString()
        {
            string result = $"Worker --- ID: {id} | Full Name: {name} | Age: {age} | " +
                $"Gender: {gender} | Address: {address} | Level: {level} \n";
            return result;
        }
    }
}
