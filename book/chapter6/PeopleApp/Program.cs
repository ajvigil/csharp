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

            // working with generic types 
            var t1 = new Thing();
            t1.Data = 42;
            WriteLine($"Thing with an integer: {t1.Process(42)}");

            var t2 = new Thing();
            t2.Data = "apple";
            WriteLine($"Thing with a string: {t2.Process("apple")}");

            var gt1 = new GenericThing<int>();
            gt1.Data = 42;
            WriteLine($"GenericThing with an integer: {gt1.Process(42)}");

            var gt2 = new GenericThing<string>();
            gt2.Data = "apple";
            WriteLine($"GenericThing with a string: {gt2.Process("apple")}");

            // working with generic methods
            string number1 = "4";
            WriteLine("{0} squared is {1}",
                arg0: number1,
                arg1: Squarer.Square<string>(number1));
            
            byte number2 = 3;
            WriteLine("{0} squared is {1}",
                arg0: number2,
                arg1: Squarer.Square(number2));

        }
        private static void Hermione_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }
    }
}