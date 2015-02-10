namespace _01.School
{
    using System.Collections.Generic;

    public class Discipline : ICommentable
    {
        public Discipline(string name, int numberOfLectures, List<Student> students)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.Students = students;
        }

        public string Name { get; set; }

        public int NumberOfLectures { get; set; }

        public List<Student> Students { get; set; }

        public string Comment { get; set; }
    }
}
