using Labb8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    //create the class with properties and constructor
    internal class Employee
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal char Gender { get; set; }
        internal int Salary { get; set; }

        internal Employee(int id, string name, char gender, int salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }
}