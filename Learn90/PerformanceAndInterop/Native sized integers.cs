using System;

namespace Learn90.PerformanceAndInterop
{
    public class Native_sized_integers
    {
        public static void Test()
        {
            unsafe
            {
                Console.WriteLine($"size of nint = {sizeof(nint)}");
                Console.WriteLine($"size of nuint = {sizeof(nuint)}");
                Console.WriteLine($"nint.MinValue = {nint.MinValue}");
                Console.WriteLine($"nint.MaxValue = {nint.MaxValue}");
                Console.WriteLine($"nuint.MinValue = {nuint.MinValue}");
                Console.WriteLine($"nuint.MaxValue = {nuint.MaxValue}");
            }

            // output when run in a 64-bit process
            //size of nint = 8
            //size of nuint = 8

            // output when run in a 32-bit process
            //size of nint = 4
            //size of nuint = 4
        }
    }
}