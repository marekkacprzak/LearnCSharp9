using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Learn90.FitAndFinishFeatures
{
    public class Attributes_on_local_functions
    {
        // Attribute	        Category	    Meaning
        // AllowNull	        Precondition	A non-nullable parameter, field, or property may be null.
        // DisallowNull	        Precondition	A nullable parameter, field, or property should never be null.
        // MaybeNull	        Postcondition	A non-nullable parameter, field, property, or return value may be null.
        // NotNull	            Postcondition	A nullable parameter, field, property, or return value will never be null.
        // MaybeNullWhen	    Conditional postcondition	A non-nullable argument may be null when the method returns the specified bool value.
        // NotNullWhen	        Conditional postcondition	A nullable argument won't be null when the method returns the specified bool value.
        // NotNullIfNotNull	    Conditional postcondition	A return value, property, or argument isn't null if the argument for the specified parameter isn't null.
        // MemberNotNull	    Method and property helper methods	The listed member won't be null when the method returns.
        // MemberNotNullWhen	Method and property helper methods	The listed member won't be null when the method returns the specified bool value.
        // DoesNotReturn	    Unreachable code	A method or property never returns. In other words, it always throws an exception.
        // DoesNotReturnIf	    Unreachable code	This method or property never returns if the associated bool parameter has the specified value.
        public class Monitor
        {
            private string _screenName="Temporary";

           [AllowNull]
            public string ScreenName
            {
                get => _screenName;
                set => _screenName = value ?? GenerateRandomScreenName();
            }
            private string GenerateRandomScreenName() => "Test";
        }
        public static void Test()
        {
            new Monitor().ScreenName = null;
            Find(new[]{"string", "str", "asdad"}, (string assd)=> assd is "str");
        }
        
        [return: MaybeNull]
        public static T Find<T>(IEnumerable<T> sequence, Func<T, bool> predicate)
        {
            var enumerator=sequence.GetEnumerator();
            enumerator.MoveNext();
            var val= enumerator.Current;
            ThrowWhenNull(val);
            void ThrowWhenNull([NotNull] object? value, string valueExpression = "") // 9.0
            {
                _ = value ?? throw new ArgumentNullException(nameof(value), valueExpression);
            }

            return val;
        }
         
    }
}