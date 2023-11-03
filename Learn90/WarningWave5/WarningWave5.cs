using System;
using System.Collections.Generic;
using System.Linq;

namespace Learn90.WarningWave5
{
    static class StaticClass
    {
        public static void Thing() { }
    }

    public class WarningWave5
    {
        public static void Test(object o)
        {
            // warning: cannot use a static type in 'is' or 'as'
            if (o is StaticClass) //Warning CS7023 
            {
                Console.WriteLine("Can't happen");
            }
            else
            {
                Console.WriteLine("o is not an instance of a static class");
            }
        }
        public  void M(Simple s)
        {
            if (s == null) { } // CS8073: The result of the expression is always 'false'
            if (s != null) { } // CS8073: The result of the expression is always 'true'
        }
    }
    public struct Simple
    {
        public static bool operator ==(Simple s1, Simple s2) => s1.Equals(s2);
        public static bool operator !=(Simple s1, Simple s2) => !s1.Equals(s2);
        public override bool Equals(object? other)
        {
            // Implementation elided
            return false;
        }
        public override int GetHashCode() => 0;
        // Other details elided...
    }
}