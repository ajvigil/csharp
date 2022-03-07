using System;
using static System.Console;
using System.IO;

namespace IterationStatements
{
  class Program
  {
    static void Main(string[] args)
    {
        //while statement 
        int x = 0;

        while (x < 10)
        {
            WriteLine(x);
            x++;
        }
        //do statement 

        string password = string.Empty;
        int attempts = 0;

        do 
        {
            attempts++;
            Write("Enter your password: ");
            password = ReadLine();
        }
        while ((password != "Pa$$w0rd") & (attempts < 10));

        if (attempts < 10)
        {
            WriteLine("Correct!");
        }
        else 
        {
            WriteLine("You have used 10 attempts!");
        }

        // looping with the for statement 

        for (int y = 1; y <= 10; y++)
        {
            WriteLine(y);
        }

        // looping with foreach

        string[] names = { "Adam", "Barry", "Charlie"};

        foreach (string name in names)
        {
            WriteLine($"{name} has {name.Length} characters.");
        }
    }
  }
}