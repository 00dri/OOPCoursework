namespace _04.HTMLDispatcher
{
    using System;

    public class Program
    {
        static void Main()
        {
            var div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 2);
            Console.WriteLine();


            var li = new ElementBuilder("li");
            li.AddAttribute("class", "nav");
            li.AddAttribute("id", "one");
            li.AddContent("Hello OOP");

            Console.WriteLine(li * 3);
            Console.WriteLine();

            var image = HtmlDispatcher.CreateImage("img.png", "sample img", "sample");
            var url = HtmlDispatcher.CreateURL("https:\\\\softuni.bg", "SoftUni", "SoftUni website");
            var input = HtmlDispatcher.CreateInput("text", "username", "student");

            Console.WriteLine(image);
            Console.WriteLine(url);
            Console.WriteLine(input);
        }
    }
}
