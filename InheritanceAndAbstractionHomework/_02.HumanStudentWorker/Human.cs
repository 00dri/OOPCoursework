namespace _02.HumanStudentWorker
{
    using System.Globalization;

    public abstract class Human
    {
        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName.ToString(CultureInfo.InvariantCulture) + " " + LastName.ToString(CultureInfo.InvariantCulture);
        }
    }
}
