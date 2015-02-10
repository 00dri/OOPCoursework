namespace _04.CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    public class Developer : RegularEmployee, IDeveloper
    {
        public List<Project> Projects { get; private set; }

        public Developer(string id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
        }

        public Developer(string id, string firstName, string lastName, decimal salary, Department department, List<Project> projects) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public override string ToString()
        {
            var baseResult = base.ToString();
            if (this.Projects == null)
            {
                return baseResult;
            }
            Console.WriteLine(baseResult + "Current Projects: ");
            var addProject = "";
            foreach (var project in Projects)
            {
                addProject += project + "\n";
            }
            return addProject;
        }
    }
}
