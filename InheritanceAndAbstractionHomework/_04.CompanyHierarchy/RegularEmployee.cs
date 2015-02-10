namespace _04.CompanyHierarchy
{
    public abstract class RegularEmployee : Employee, IRegularEmployee
    {
        protected RegularEmployee(string id, string firstName, string lastName, decimal salary, Department department) 
            : base(id, firstName, lastName, salary, department)
        {
        }
    }
}
