namespace _01.School
{
    public abstract class People : ICommentable
    {
        protected People(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public abstract string Comment { get; set; }
    }
}
