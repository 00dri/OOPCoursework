namespace ConsoleForum.Entities.Posts
{
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
    }
}
