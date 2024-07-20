using System;

class Program
{
    static void Main()
    {
        // ASCII Art of a Cat and Dog 
        Console.ForegroundColor = ConsoleColor.Green;
        string asciiArt = @"
  /\_/\  
 ( o.o ) 
  > ^ <

   ^
  / \__
 (    @\___
 /         O
/   (_____/
/_____/   

";

        Console.Clear(); // Clear the console window
        Console.WriteLine(asciiArt); // Print ASCII Art
        //Console.ReadLine(); // Wait for user input
    }
}