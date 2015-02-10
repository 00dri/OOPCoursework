namespace _04.CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    public class Manager : Employee, IManager
    {
        public List<Employee> Employees { get; private set; }

        public Manager(string id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
        }

        public Manager(string id, string firstName, string lastName, decimal salary, Department department, List<Employee> employees) 
            : this(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public override string ToString()
        {
            var baseResult = base.ToString();
            if (this.Employees == null)
            {
                return baseResult;
            }
            Console.WriteLine(baseResult + "Current Employees: ");
            var addEmployee = "";
            foreach (var employee in Employees)
            {
                addEmployee += employee.FirstName + " " + employee.LastName + "\n";
            }
            return addEmployee;
        }
    }
}
