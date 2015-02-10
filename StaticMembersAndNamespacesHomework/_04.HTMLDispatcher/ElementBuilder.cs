namespace _04.HTMLDispatcher
{
    using System;

    public class ElementBuilder
    {
        private string name;

        public ElementBuilder(string name)
        {
            Content = "";
            Name = name;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Element name cannot be null or empty");
                    throw new ArgumentNullException();
                }

                name = value;
            }
        }

        public string Attributes { get; set; }

        public string Content { get; set; }

        public void AddAttribute(string attribute, string value)
        {
            Attributes += " " + attribute + "=\"" + value + "\"";
        }

        public void AddContent(string contentToAdd)
        {
            Content += contentToAdd;
        }

        public static string operator *(ElementBuilder e, int n)
        {
            var result = "";
            for (int i = 0; i < n; i++)
            {
                result += e;
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format("<{0}{1}>{2}</{0}>", Name, Attributes, Content);
        }
    }
}
