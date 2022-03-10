using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var hermione = new Person { Name = "Hermione" };
            var ginny = new Person { Name = "Ginny" };
            var cho = new Person { Name = "Cho" };

            // call instance method 
            var baby1 = ginny.ProcreateWith(hermione);

            // call static method 
            var baby2 = Person.Procreate(hermione, cho);

            // call an operator 
            var baby3 = hermione * ginny;

            WriteLine($"{hermione.Name} has {hermione.Children.Count} children.");
            WriteLine($"{ginny.Name} has {ginny.Children.Count} children.");
            WriteLine($"{cho.Name} has {cho.Children.Count} children");

            WriteLine(
                format: "{0}'s first child is named \"{1}\".",
                arg0: hermione.Name,
                arg1: hermione.Children[0].Name);
            
            // Implementing functionality using local functions
            WriteLine($"5! is {Person.Factorial(5)}");

            // raising and handling events 
            hermione.Shout += Hermione_Shout;

            hermione.Poke();
            hermione.Poke();
            hermione.Poke();
            hermione.Poke();

            // comparing objects when sorting
            Person[] people = 
            {
                new Person { Name = "Snape" }, 
                new Person { Name = "Voldemort" }, 
                new Person { Name = "Bellatrix" }, 
                new Person { Name = "Umbridge" }
            };

            WriteLine("Initial list of people:");
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }
            
            WriteLine("Use Person's IComparable implementation to sort:");
            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }
            
            // comparing objects using a separate class
            WriteLine("Use PersonsComparer's IComparer implementation to sort:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

        }
        private static void Hermione_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }
    }
}