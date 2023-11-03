using System;
using System.Runtime.CompilerServices;

namespace Learn90.PerformanceAndInterop
{
    [System.Runtime.CompilerServices.SkipLocalsInit]
    public class SkipLocalsInit_attribute
    {
        [SkipLocalsInit]
        public  static unsafe  void Test()
        {
            int i;
            Console.WriteLine(*&i);// Unpredictable output as i is not initialized
        }
    }
    
    // For the project
    //[module: System.Runtime.CompilerServices.SkipLocalsInit]

    // For a class
    // [System.Runtime.CompilerServices.SkipLocalsInit]
    // class Sample
    // {
    //     // ...
    // }

// For a method
    // [System.Runtime.CompilerServices.SkipLocalsInit]
    // unsafe void Sample()
    // {
    // }

// For a variable
    // void Sample()
    // {
    //     int i;
    //     System.Runtime.CompilerServices.Unsafe.SkipInit(out i);
    // }
}