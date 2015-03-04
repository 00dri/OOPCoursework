namespace ConsoleForum.Entities.Posts
{
    using Contracts;

    public class BestAnswer : Answer
    {
        public BestAnswer(int id, string body, IUser author) 
            : base(id, body, author)
        {
        }
    }
}
