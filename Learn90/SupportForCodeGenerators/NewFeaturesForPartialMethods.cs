using System;

namespace Learn90.SupportForCodeGenerators
{
    public partial class NewFeaturesForPartialMethods
    {
        // Okay because no definition is required here
        partial void M1();

        // Okay because M2 has a definition
        private partial void M2();

        //Error CS8795 : Partial method must have an implementation part because it has accessibility modifiers.
        //private partial void M3();
    }
    public partial class NewFeaturesForPartialMethods
    {
        public static void Test()
        {
            new NewFeaturesForPartialMethods().M2();
        }
        private partial void M2()
        {
            Console.WriteLine($"Partial method {new C().GetName()}");
        }
    }
    
    interface IStudent
    {
        string GetName();
    }

    partial class C : IStudent
    {
        public virtual partial string GetName(); 
    }

    partial class C
    {
        public virtual partial string GetName() => "Marek";
    }
}