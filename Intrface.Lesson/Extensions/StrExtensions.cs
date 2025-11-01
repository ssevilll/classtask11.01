namespace Intrface.Lesson.Extensions
{
    internal static class StrExtensions
    {
        public static int MatchCount(this string str, string substring)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(substring))
            {
                return 0;
            }
            int count = 0;
            int index = 0;
            while ((index = str.IndexOf(substring, index, StringComparison.Ordinal)) != -1)
            {
                count++;
                index += substring.Length;
            }
            return count;
        }
    }
}
