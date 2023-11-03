namespace Learn90.PatternMatchingEnhancements
{
    public class Typetest_patterns
    {
        public static void M(object o1, object o2)
        {
            var t = (o1, o2);
            switch (o1)
            {
                case int: break; // test if o1 is an int    c# 9.0
                case System.String: break; // test if o1 is a string
            }

            t.o1 = 2;
        }
    }
}