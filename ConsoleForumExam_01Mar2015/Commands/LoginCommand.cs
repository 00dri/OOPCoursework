namespace ConsoleForum.Commands
{
    using System.Linq;
    using Contracts;
    using Utility;

    public class LoginCommand : AbstractCommand
    {
        public LoginCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            var username = this.Data[1];
            var password = this.Data[2];
            var existingUser = this.Forum.Users.FirstOrDefault(u => u.Username == username && u.Password == PasswordUtility.Hash(password));

            if (this.Forum.IsLogged)
            {
                throw new CommandException(Messages.AlreadyLoggedIn);
            }

            if (existingUser == null)
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }

            this.Forum.CurrentUser = existingUser;
            this.Forum.Output.AppendFormat(Messages.LoginSuccess, existingUser.Username);
        }
    }
}
