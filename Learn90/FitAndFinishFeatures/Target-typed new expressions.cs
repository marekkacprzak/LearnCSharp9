using System;
using System.Collections.Generic;

namespace Learn90.FitAndFinishFeatures
{
    public class Target_typed_new_expressions
    {
        static readonly Dictionary<string, List<int>> field = new() { // c# 9.0
            { "item1", new() { 1, 2, 3 } } // c# 9.0
        };
        public static void Test()
        {
            Console.WriteLine($"Target type new expression: {field["item1"][0]}");
        }
    }
}