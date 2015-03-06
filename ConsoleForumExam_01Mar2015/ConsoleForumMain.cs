namespace ConsoleForum
{
    using System;
    using System.IO;
    using ConsoleForum.Contracts;

    public class ConsoleForumMain
    {
        public static void Main()
        {
            IForum forum = new ExtendedForum();
            forum.Run();

            //For testing:
            //var output = new StreamWriter("../../out.txt");
            //using (output)
            //{
            //    Console.SetOut(output);
            //    IForum forum = new Forum();
            //    forum.Run();
            //}
        }
    }
}
