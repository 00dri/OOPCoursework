namespace ConsoleForum.Entities.Posts
{
    using System.Text;
    using Contracts;
    using Utility;

    public class BestAnswer : Answer
    {
        public BestAnswer(int id, string body, IUser author)
            : base(id, body, author)
        {
        }

        public override string ToString()
        {
            var bestAnswer = new StringBuilder();
            bestAnswer.AppendLine(new string('*', OutputUtility.DefaultDelimiterLength))
                .AppendLine(base.ToString())
                .AppendLine(new string('*', OutputUtility.DefaultDelimiterLength));
            return bestAnswer.ToString();
        }
    }
}
