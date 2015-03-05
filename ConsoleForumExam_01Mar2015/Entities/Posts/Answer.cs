namespace ConsoleForum.Entities.Posts
{
    using System.Text;
    using Contracts;

    public class Answer : IAnswer
    {
        public Answer(int id, string body, IUser author)
        {
            this.Id = id;
            this.Body = body;
            this.Author = author;
        }

        public int Id { get; set; }
        public string Body { get; set; }
        public IUser Author { get; set; }

        public override string ToString()
        {
            var answer = new StringBuilder();
            answer.AppendFormat("[ Answer ID: {0} ]", this.Id).AppendLine();
            answer.AppendFormat("Posted by: {0}", this.Author).AppendLine();
            answer.AppendFormat("Answer Body: {0}", this.Body).AppendLine();

            return answer.ToString();
        }
    }
}
