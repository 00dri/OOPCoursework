namespace ConsoleForum.Commands
{
    using Contracts;

    public class ExitCommand : AbstractCommand
    {
        public ExitCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
