namespace ConsoleForum.Commands
{
    using Contracts;
    using Entities.Posts;

    public class PostQuestionCommand : AbstractCommand
    {
        public PostQuestionCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            var title = this.Data[1];
            var body = this.Data[2];
            var questionsList = this.Forum.Questions;
            var author = this.Forum.CurrentUser;

            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }

            var post = new Question(questionsList.Count + 1, body, author, title);
            questionsList.Add(post);
            this.Forum.Output.AppendFormat(Messages.PostQuestionSuccess, post.Id).AppendLine();
        }
    }
}
