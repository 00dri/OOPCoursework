using System;

namespace _04.CompanyHierarchy
{
    public interface IProject
    {
        string ProjectName { get; set; }
        DateTime ProjectStartDate { get; set; }
        string Details { get; set; }
        State State { get; set; }
    }
}