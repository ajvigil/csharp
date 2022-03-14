using System;
using static System.Console;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting the length of a string
            string city = "London";
            WriteLine($"{city} is {city.Length} characters long.");

            // Getting characters of a string
            WriteLine($"First char is {city[0]} and third is {city[2]}.");

            // Splitting a string
            string cities = "Paris,Berlin,Madrid,New York";

            string[] citiesArray = cities.Split(',');

            foreach (string item in citiesArray)
            {
                WriteLine(item);
            }
        }
    }
}