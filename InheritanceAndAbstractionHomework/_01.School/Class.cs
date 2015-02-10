namespace _01.School
{
    using System.Collections.Generic;

    public class Class : ICommentable
    {
        private readonly SortedSet<Teacher> teachers = new SortedSet<Teacher>();

        public Class(string uniqueTextIdentifier)
        {
            this.UniqueTextIdentifier = uniqueTextIdentifier;
        }

        public string UniqueTextIdentifier { get; set; }
        public string Comment { get; set; }
    }
}
