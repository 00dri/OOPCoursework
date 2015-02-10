namespace _04.SoftUniLearningSystem
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, int age, int studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public int StudentNumber { get; set; }

        public double AverageGrade { get; set; }
    }
}
