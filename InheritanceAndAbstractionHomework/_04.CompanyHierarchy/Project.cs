namespace _04.CompanyHierarchy
{
    using System;

    public class Project : IProject
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private State state;

        public Project(string projectName, DateTime projectStartDate, string details, State state)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = state;
        }

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }

        public DateTime ProjectStartDate
        {
            get { return projectStartDate; }
            set { projectStartDate = value; }
        }

        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", this.ProjectName, this.ProjectStartDate, this.Details, this.State);
        }
    }
}
