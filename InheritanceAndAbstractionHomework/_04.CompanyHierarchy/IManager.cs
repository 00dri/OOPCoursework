﻿namespace _04.CompanyHierarchy
{
    public interface IManager
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
        string Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}