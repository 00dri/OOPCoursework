namespace _04.HTMLDispatcher
{
    public class HtmlDispatcher
    {
        public static string CreateImage(string source, string alt, string title)
        {
            var e = new ElementBuilder("img");
            e.AddAttribute("src", source);
            e.AddAttribute("alt", alt);
            e.AddAttribute("title", title);

            return e.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            var e = new ElementBuilder("a");
            e.AddAttribute("href", url);
            e.AddAttribute("title", title);
            e.AddContent(text);

            return e.ToString();
        }

        public static string CreateInput(string inputType, string name, string value)
        {
            var e = new ElementBuilder("input");
            e.AddAttribute("type", inputType);
            e.AddAttribute("name", name);
            e.AddAttribute("value", value);

            return e.ToString();
        }
    }
}
