namespace DesignPatterns.Chapters.Proxies.ExtensionMethods
{
    public static class PercentageProxyExtensions
    {
        public static Percentage Percent(this int value)
        {
            return new Percentage(value / 100.0f);
        }
        public static Percentage Percent(this float value)
        {
            return new Percentage(value / 100.0f);
        }
    }
}
