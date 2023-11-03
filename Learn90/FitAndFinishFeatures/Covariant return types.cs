namespace Learn90.FitAndFinishFeatures
{
    public static class Covariant_return_types
    {
        public class Animal
        {
            public virtual Animal? MakeSound()
            {
                return null;
            }
        }

        public class Dog : Animal
        {
            public override Dog? MakeSound()
            {
                return new Dog(); //Error in c# 8.0
            }
        }

        public static void Test()
        {
            var animal = new Dog();
            var dog = animal.MakeSound(); // dog is of type Dog
        }

    }
}