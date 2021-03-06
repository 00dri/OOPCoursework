﻿namespace ConsoleForum.Commands
{
    using System.Linq;
    using Contracts;
    using Utility;

    public class ShowQuestionsCommand : AbstractCommand
    {
        public ShowQuestionsCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.Questions.Any())
            {
                throw new CommandException(Messages.NoQuestions);
            }
            this.Forum.CurrentQuestion = null;
            this.Forum.Output.AppendLine(OutputUtility.ShowSortedQuestions(this.Forum.Questions));
        }
    }
}
