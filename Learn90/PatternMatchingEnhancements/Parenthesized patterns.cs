namespace Learn90.PatternMatchingEnhancements
{
    public class Parenthesized_patterns
    {
        public static void M(object o1, object o2)
        {
            var t = (o1, o2);
            if (t is (int, string))
            {
            } // test if o1 is an int and o2 is a string C# 9.0
        }
    }
}