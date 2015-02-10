namespace _04.SoftUniLearningSystem
{
    using System;
    using System.Collections.Generic;

    public class Trainer : Person
    {
        protected IList<string> courses = new List<string>();

        public Trainer(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {
        }

        public IList<string> Courses
        {
            get { return this.courses; }
        }

        public void CreateCourse(string courseName)
        {
            this.courses.Add(courseName);
            Console.WriteLine("The course has been created: {0}", courseName);
        }
    }
}
