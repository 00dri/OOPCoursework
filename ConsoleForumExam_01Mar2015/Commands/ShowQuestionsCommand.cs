namespace ConsoleForum.Commands
{
    using System.Linq;
    using Contracts;

    public class ShowQuestionsCommand : AbstractCommand
    {
        public ShowQuestionsCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.Questions.Any())
            {
                throw new CommandException(Messages.NoQuestion);
            }
            var questions = this.Forum.Questions.OrderBy(q => q.Id);

            foreach (var question in questions)
            {
                
            }

        }

    }
}
