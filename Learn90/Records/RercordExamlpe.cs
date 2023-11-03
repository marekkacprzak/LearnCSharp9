using static System.Console;

namespace Learn90.Records
{
    public static class RercordExamlpe
    {
        public static void Test()
        {
            var person1 = new Person("Marek", "Kacprzak");
            var person2 = new Person("Marek", "Kacprzak");
            
            WriteLine($"Person1==Person2 {person1==person2}");
            WriteLine($"Person1 ref equal Person2 {ReferenceEquals(person1,person2)}");
            var person3 = new Person2("Marek", "Kacprzak",40)
            {
                FirstName = "test",
                Age = 36,
            };
            WriteLine($"person3: {person3}");
            WriteLine($"Hidden Age: {person3.Age}");
            //person3.FirstName = "test"; //error
            (var firstName, var lastName, int age) = person3;
            WriteLine($"{firstName} {lastName} {age}");

            var personNew = person1 with { FirstName = "Jarek" }; //Don't do it shallow copy
            WriteLine($"Person1==personNew {person1==personNew}");
            WriteLine($"Person1 ref equal personNew {ReferenceEquals(person1,personNew)}");

        }
    }
}