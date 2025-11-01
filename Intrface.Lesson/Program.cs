using Intrface.Lesson.Extensions;

namespace Intrface.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int a = 3;
            //Console.WriteLine(a.IsEven());
            //Console.WriteLine(a.IsOdd());

            //string str = "hello world1. this is c#.";
            //Console.WriteLine(str.IsContainsDigit());
            //Console.WriteLine(str.ToCapitalize());
            //var indexes = str.GetValueIndexes('o');
            //foreach (var index in indexes)
            //{
            //    Console.WriteLine(index);
            //}
            //Console.WriteLine(str.GetFirstSentence());
            //Console.WriteLine(str.GetSecondWord());
            #endregion

            string test = "Salam Kamran. Necəsən Kamran";
            string substring = "Kamran";
            Console.WriteLine(test.MatchCount(substring));
        }
    }
}
