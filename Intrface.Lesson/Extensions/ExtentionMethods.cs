namespace Intrface.Lesson.Extensions
{
    internal static class ExtentionMethods
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsContainsDigit(this string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static string ToCapitalize(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            return char.ToUpper(str[0]) + str.Substring(1);
        }

        public static int[] GetValueIndexes(this string str, char character)
        {
            int[] indexes = new int[str.Length];
            int j = 0;
            for (int i = 0; i <str.Length; i++)
            {
                if (str[i] == character)
                {
                    indexes[j++] = i;
                }
            }
            if (j==0)
            {
                return [];
            }
            else
            {
                Array.Resize(ref indexes, j);
            }
            return indexes;
        }

        public static string GetFirstSentence(this string str)
        {
            int periodIndex = str.IndexOf('.');
            if (periodIndex != -1)
            {
                return str.Substring(0, periodIndex + 1);
            }
            return str;
        }

        public static string GetSecondWord(this string str)
        {
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (words.Length >= 2)
            {
                return words[1];
            }
            return string.Empty;
        }
    }
}
