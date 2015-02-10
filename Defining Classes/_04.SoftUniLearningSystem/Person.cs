namespace _04.SoftUniLearningSystem
{
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: Name: {1} {2}, {3} years old", GetType().Name, this.FirstName, this.LastName, this.Age);
        }
    }
}
