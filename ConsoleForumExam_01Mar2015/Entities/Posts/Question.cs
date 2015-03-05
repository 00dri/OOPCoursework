namespace ConsoleForum.Entities.Posts
{
    using System.Collections.Generic;
    using System.Text;
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

        public override string ToString()
        {
            var question = new StringBuilder();
            question.AppendFormat("[ Question ID: {0} ]", this.Id).AppendLine();
            question.AppendFormat("Posted by: {0}", this.Author).AppendLine();
            question.AppendFormat("Question Title: {0}", this.Title).AppendLine();
            question.AppendFormat("Question Body: {0}", this.Body).AppendLine();

            return question.ToString();
        }
    }
}
