﻿namespace ConsoleForum.Commands
{
    using System.Linq;
    using Contracts;
    using Entities.Posts;

    public class MakeBestAnswerCommand : AbstractCommand
    {
        public MakeBestAnswerCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }
            if (this.Forum.CurrentQuestion == null)
            {
                throw new CommandException(Messages.NoQuestionOpened);
            }

            var user = this.Forum.CurrentUser;
            var answerId = int.Parse(this.Data[1]);
            var author = this.Forum.CurrentUser;
            var question = this.Forum.CurrentQuestion;
            var answer = this.Forum.Answers.FirstOrDefault(a => a.Id == answerId);

            if (answer == null)
            {
                throw new CommandException(Messages.NoAnswer);
            }
            if (!(user is IAdministrator || question.Author == user))
            {
                throw new CommandException(Messages.NoPermission);
            }
            if (this.Forum.CurrentQuestion == null)
            {
                throw new CommandException(Messages.NoQuestionOpened);
            }

            var bestAnswer = new BestAnswer(answer.Id, answer.Body, answer.Author);
            this.Forum.Answers.Remove(answer);
            this.Forum.Answers.Add(bestAnswer);
            question.Answers.Remove(answer);
            question.Answers.Add(bestAnswer);

            this.Forum.Output.AppendFormat(Messages.BestAnswerSuccess, bestAnswer.Id).AppendLine();
        }
    }
}
