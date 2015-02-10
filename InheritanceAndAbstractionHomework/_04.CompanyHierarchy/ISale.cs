using System;

namespace _04.CompanyHierarchy
{
    public interface ISale
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }
    }
}