namespace ConsoleForum.Commands
{
    using Contracts;

    public class PostAnswerCommand : AbstractCommand
    {
        public PostAnswerCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
