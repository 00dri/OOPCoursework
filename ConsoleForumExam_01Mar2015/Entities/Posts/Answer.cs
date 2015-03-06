namespace ConsoleForum.Entities.Posts
{
    using System.Text;
    using Contracts;
    using Utility;

    public class Answer : Post, IAnswer
    {
        public Answer(int id, string body, IUser author)
            : base(id, body, author)
        {
        }

        public override string ToString()
        {
            var answer = new StringBuilder();
            answer.AppendFormat("[ Answer ID: {0} ]", this.Id).AppendLine();
            answer.AppendFormat("Posted by: {0}", this.Author).AppendLine();
            answer.AppendFormat("Answer Body: {0}", this.Body).AppendLine();
            answer.Append(new string('-', OutputUtility.DefaultDelimiterLength));

            return answer.ToString();
        }
    }
}
