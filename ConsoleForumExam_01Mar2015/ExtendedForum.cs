namespace ConsoleForum
{
    using System;
    using System.Linq;
    using Entities.Posts;
    using Utility;

    public class ExtendedForum : Forum
    {
        protected override void ExecuteCommandLoop()
        {
            this.Output.Clear();
            this.Output.AppendLine(new string('~', OutputUtility.DefaultDelimiterLength));

            if (this.IsLogged)
            {
                this.Output.AppendFormat(Messages.UserWelcomeMessage, this.CurrentUser.ToString()).AppendLine();
            }
            else
            {
                this.Output.AppendLine(Messages.GuestWelcomeMessage);
            }

            var hotQuestions = this.Questions.Count(q => q.Answers.Any(a => a is BestAnswer));
            var activeUsers = this.Answers.GroupBy(a => a.Author.Id).Where(group => group.Count() >= 3).Count();
            this.Output.AppendFormat(Messages.GeneralHeaderMessage, hotQuestions, activeUsers).AppendLine();
            this.Output.AppendLine(new string('~', OutputUtility.DefaultDelimiterLength));
            Console.Write(Output);

            base.ExecuteCommandLoop();
        }
    }
}
