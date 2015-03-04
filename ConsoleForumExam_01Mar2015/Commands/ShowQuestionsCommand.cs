namespace ConsoleForum.Commands
{
    using Contracts;

    public class ShowQuestionsCommand : AbstractCommand
    {
        public ShowQuestionsCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
