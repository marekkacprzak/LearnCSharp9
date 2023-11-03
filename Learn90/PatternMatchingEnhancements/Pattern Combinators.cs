using System;

namespace Learn90.PatternMatchingEnhancements
{
    public class  Pattern_combinators
    {
        public bool IsLetter(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
        
        public bool IsLetter2(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');
        
        bool IsValidPercentage(int x) => x is >= 0 and <= 100;
        
        bool IsValidPercentage(object x) => x is
            >= 0 and <= 100 or    // integer tests
            >= 0F and <= 100F or  // float tests
            >= 0D and <= 100D;    // double tests
        
        bool isSmallByte(object o) => o is byte and not < 100;

        public static void Test()
        {
            var b = new Random().Next();
            int x = b switch { <100 => 0, 100 => 1, 101 => 2, >101 => 3 };
        }
    }
}