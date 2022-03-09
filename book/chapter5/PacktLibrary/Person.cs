using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : object
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
    }
}

