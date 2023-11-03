using System;

namespace Learn90.FitAndFinishFeatures
{
    public class Static_anonymous_method
    {
        private const string formattedText = "{0} It was developed by Microsoft's Anders Hejlsberg in the year 2000.";
        void DisplayText(Func<string, string> func)
        {
            Console.WriteLine(func("C# is a popular programming language."));
        }
        public void Display()
        {
            DisplayText(static text => string.Format(formattedText, text)); // static keyword c# 9.0
        }

        public static void Test()
        {
            new Static_anonymous_method().Display();
        }
    }
}