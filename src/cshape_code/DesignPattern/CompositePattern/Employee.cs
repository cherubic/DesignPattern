using System;
using System.Collections.Generic;

namespace DesignPattern.CompositePattern
{
    public class Employee
    {
        private string name;
        private string dept;
        private int salary;
        public List<Employee> Subordinates { get; private set; }

        public Employee(string name, string dept, int sal)
        {
            this.name = name;
            this.dept = dept;
            this.salary = sal;
            this.Subordinates = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            Subordinates.Add(employee);
        }

        public void remove(Employee employee)
        {
            Subordinates.Remove(employee);
        }

        public override string ToString()
        {
            return ("Employee :[ Name : " + name
      + ", dept : " + dept + ", salary :"
      + salary + " ]");
        }
    }
}
