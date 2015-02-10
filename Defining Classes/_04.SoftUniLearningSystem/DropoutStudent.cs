namespace _04.SoftUniLearningSystem
{
    using System;

    public class DropoutStudent : Student
    {
        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string dropoutReason) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Dropout reason: {0}", this.DropoutReason);
        }

        public void Reapply()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
