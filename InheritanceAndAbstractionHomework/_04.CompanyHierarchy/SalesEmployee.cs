namespace _04.CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public List<Sale> Sales { get; private set; }

        public SalesEmployee(string id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
        }

        public SalesEmployee(string id, string firstName, string lastName, decimal salary, Department department, List<Sale> sales) 
            : this(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public override string ToString()
        {
            var baseResult = base.ToString();
            if (this.Sales == null)
            {
                return baseResult;
            }
            Console.WriteLine(baseResult + "Current Sales: ");
            var addSales = "";
            foreach (var sale in Sales)
            {
                addSales += sale + "\n";
            }
            return addSales;
        }
    }
}
