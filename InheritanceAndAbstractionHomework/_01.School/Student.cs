namespace _01.School
{
    public class Student : People
    {
        public Student(string name, string uniqueClassNumber)
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public string UniqueClassNumber { get; set; }

        public override string Comment { get; set; }
    }
}
