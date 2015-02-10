namespace _04.SoftUniLearningSystem
{
    using System;

    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {
        }

        public void DeleteCourse(string courseName)
        {
            this.courses.Remove(courseName);
            Console.WriteLine("The course has been deleted: {0}", courseName);
        }
    }
}
