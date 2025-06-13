namespace Common.Helpers
{
    public static class WordHelper
    {
        public static string Pluralize(string word)
        {
            if (string.IsNullOrEmpty(word))
                return word;

            if (word.EndsWith("y", StringComparison.OrdinalIgnoreCase) &&
                !word.EndsWith("ay", StringComparison.OrdinalIgnoreCase) &&
                !word.EndsWith("ey", StringComparison.OrdinalIgnoreCase) &&
                !word.EndsWith("iy", StringComparison.OrdinalIgnoreCase) &&
                !word.EndsWith("oy", StringComparison.OrdinalIgnoreCase) &&
                !word.EndsWith("uy", StringComparison.OrdinalIgnoreCase))
            {
                return word.Substring(0, word.Length - 1) + "ies";
            }
            else if (word.EndsWith("s") ||
                     word.EndsWith("x") ||
                     word.EndsWith("z") ||
                     word.EndsWith("ch") ||
                     word.EndsWith("sh"))
            {
                return word + "es";
            }
            else
            {
                return word + "s";
            }
        }
    }
}
