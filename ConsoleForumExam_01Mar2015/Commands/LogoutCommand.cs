namespace ConsoleForum.Commands
{
    using Contracts;

    public class LogoutCommand : AbstractCommand
    {
        public LogoutCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
