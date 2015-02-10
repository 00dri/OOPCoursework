namespace _04.CompanyHierarchy
{
    using System;

    public abstract class Employee : Person, IEmployee
    {
        private const string NegativeSalaryError = "Salary cannot be negative or zero!";

        private decimal salary;

        public Employee(string id, string firstName, string lastName, decimal salary, Department department)
            :base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get {
                if (!(this.salary > 0))
                {
                    throw new ArgumentOutOfRangeException(NegativeSalaryError);
                }
                return salary; 
            }
            set { salary = value; }
        }

        public Department Department { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\nSalary: {1}\nDepartment: {2}\n", base.ToString(), this.Salary.ToString("C0"), this.Department);
        }
    }
}
