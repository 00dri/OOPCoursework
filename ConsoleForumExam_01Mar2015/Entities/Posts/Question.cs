namespace ConsoleForum.Entities.Posts
{
    using System.Collections.Generic;
    using Contracts;

    public class Question : IQuestion
    {
        public Question(int id, string body, IUser author, string title, IList<IAnswer> answers)
        {
            this.Id = id;
            this.Body = body;
            this.Author = author;
            this.Title = title;
            this.Answers = answers;
        }

        public int Id { get; set; }
        public string Body { get; set; }
        public IUser Author { get; set; }
        public string Title { get; set; }
        public IList<IAnswer> Answers { get; private set; }
    }
}
