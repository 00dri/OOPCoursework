namespace _02.HumanStudentWorker
{
    using System;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string faultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = faultyNumber;
        }

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set {
                if (value.Length < 5 && value.Length > 10)
                {
                    Console.Error.Write("Length is between 5 and 10 digits/letters");
                }
                facultyNumber = value; 
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + FacultyNumber;
        }
    }
}
