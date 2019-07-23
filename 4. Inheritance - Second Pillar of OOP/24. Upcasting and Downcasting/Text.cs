namespace Upcasting_and_Downcasting
{
    public class Text : Shape
    {
        public int FontSite { get; set; }
        public string FontName { get; set; }

        public Text()
        {
            FontName = "Arial";
            FontSite = 10;
        }
    }
}
