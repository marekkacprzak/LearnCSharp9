using System;

namespace Learn90.FitAndFinishFeatures
{
    public static class Lambda_discard_parameters
    {
        public static void Test()
        {
            Func<int, int, int> constant = (_, _) => 42;
            Console.WriteLine(constant(1, 2));
        }
    }
}