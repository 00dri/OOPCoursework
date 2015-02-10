namespace _04.SoftUniLearningSystem
{
    public class Current : Student
    {
        public Current(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse { get; set; }
    }
}
