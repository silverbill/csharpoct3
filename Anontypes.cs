using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] movies = new string [3]{ "Lonesome Dove", "Big Trouble", "Field of" };
        movies.GetUpperBound(0);
        Console.WriteLine(movies.GetUpperBound(0));
        Console.WriteLine(movies[2]);
        Console.WriteLine("the last movie in the array is " + movies[2]);
        Console.ReadLine();

        var gaucho = new { Age = 39, Slogan = "Bitches", Value = 12.12 };

        // Rest the mouse pointer over v.Amount and v.Message in the following
        // statement to verify that their inferred types are int and string.
        Console.WriteLine(gaucho.Age + gaucho.Slogan + gaucho.Value);
    }
    
}