namespace Learn90.Records
{
    public record Person(string FirstName, string LastName)
    {
    }
    
    public record Person2(string FirstName, string LastName, int Age)
    {   
        internal int Age { get; init; } = Age;
    }
    
    public record PersonDonDoIt() //No constructor so no deconstructor
    {   
         public string MoreInfo { get; set; } //(The set makes the record mutable)
    }
}