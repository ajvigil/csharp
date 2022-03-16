using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public partial class Person : object
    {
        // fields 
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        // constants 
        public const string Species = "Homo Sapien";

        // read-only fields 
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        // constructors 
        public Person()
        {
            // set default values for fields
            // including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        // methods 

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        // tuples 
        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }
        // naming fields of tuples 
        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        // parameters 
        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }
        public string SayHelloTo(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }
        
        //optional parameters
        public string OptionalParameters(
            string command = "Run!",
            double number = 0.0,
            bool active = true)
        {
            return string.Format(
                format: "command is {0}, number is {1}, active is {2}",
                arg0: command, arg1: number, arg2: active);
        }

        // passing parameters in and out 
        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannout have a default 
            // AND must be initialized inside the method 
            z = 99;

            // increment each parameter
            x++;
            y++;
            z++;
        }
    }
}

