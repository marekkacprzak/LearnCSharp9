namespace Learn90.PatternMatchingEnhancements
{
    public enum Season { Default, Spring, Summer, Autumn, Winter }
    public class Relational_patterns
    {
        public static Season LifeStageAtAge(int age) => age switch
        {
            < 0 =>  Season.Spring,
            < 2 =>  Season.Autumn,
            < 4 =>  Season.Summer,
            < 6 =>  Season.Winter,
            _ =>    Season.Default,
        };

    }
}