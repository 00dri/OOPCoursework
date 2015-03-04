namespace ConsoleForum.Commands
{
    using Contracts;

    public class LoginCommand : AbstractCommand
    {
        public LoginCommand(IForum forum) 
            : base(forum)
        {
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
