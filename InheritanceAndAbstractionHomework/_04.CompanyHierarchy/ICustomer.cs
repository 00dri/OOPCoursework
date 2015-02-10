namespace _04.CompanyHierarchy
{
    public interface ICustomer
    {
        int NetPurchaseAmount { get; set; }
        string Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}