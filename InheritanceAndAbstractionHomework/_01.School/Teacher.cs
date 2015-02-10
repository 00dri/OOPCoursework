namespace _01.School
{
    public class Teacher : People
    {
        public Teacher(string name)
            : base(name)
        {
        }

        public override string Comment { get; set; }
    }
}
