namespace ConsoleForum.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;

    public static class OutputUtility
    {
        public const int DefaultDelimiterLength = 20;

        public static string ShowSortedQuestions(IEnumerable<IQuestion> questions)
        {
            var questionsSorted = questions.OrderBy(q => q.Id);
            return string.Join(Environment.NewLine, questionsSorted);
        }
    }
}
