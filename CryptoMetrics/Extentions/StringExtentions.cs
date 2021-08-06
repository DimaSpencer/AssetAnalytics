namespace DataParser
{
    public static class StringExtentions
    {
        public static string ParseValue(this string text)
        {
            text = text.Replace(@"$", string.Empty);
            text =  text.Replace(@".", string.Empty);
            text =  text.Replace(@",", string.Empty);
            return text;
        }
        public static string WithDollarSymbol(this string text)
        {
            return text.Replace(@"$", string.Empty);
        }
    }
}
