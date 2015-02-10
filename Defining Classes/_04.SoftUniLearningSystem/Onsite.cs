namespace _04.SoftUniLearningSystem
{
    public class Onsite : Current
    {
        public Onsite(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse, int numberOfVisits) 
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits { get; set; }
    }
}
