namespace Inheritance
{
    class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        public void AddHyperLink(string url)
        {
            System.Console.WriteLine("we added a linl to " + url);
        }
    }
}
