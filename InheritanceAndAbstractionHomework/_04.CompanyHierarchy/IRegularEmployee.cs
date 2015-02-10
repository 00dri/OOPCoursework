namespace _04.CompanyHierarchy
{
    public interface IRegularEmployee
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
        string Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}