﻿namespace ConsoleForum.Entities.Posts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Contracts;

    public class Question : Post, IQuestion
    {
        public Question(int id, string body, IUser author, string title)
            : base(id, body, author)
        {
            this.Title = title;
            this.Answers = new List<IAnswer>();
        }

        public string Title { get; set; }
        public IList<IAnswer> Answers { get; private set; }

        public override string ToString()
        {
            var question = new StringBuilder();
            question.AppendFormat("[ Question ID: {0} ]", this.Id).AppendLine();
            question.AppendFormat("Posted by: {0}", this.Author).AppendLine();
            question.AppendFormat("Question Title: {0}", this.Title).AppendLine();
            question.AppendFormat("Question Body: {0}", this.Body).AppendLine();
            question.AppendLine(new string('=', 20));

            if (!this.Answers.Any())
            {
                question.Append("No answers");
            }
            else
            {
                var bestAnswer = this.Answers.FirstOrDefault(a => a is BestAnswer);
                string answersAsString;
                question.AppendLine("Answers:");
                if (bestAnswer != null)
                {
                    question.Append(bestAnswer);
                    var otherAnswers = this.Answers.Where(a => a.Id != bestAnswer.Id).OrderBy(a => a.Id);
                    answersAsString = string.Join(Environment.NewLine, otherAnswers.Select(a => a.ToString()));
                }
                else
                {
                    answersAsString = string.Join(Environment.NewLine, this.Answers.Select(a => a.ToString()));
                }
                question.Append(answersAsString);
            }

            return question.ToString();
        }
    }
}
