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

            WriteLine($"{hermione.Name} has {hermione.Children.Count} children.");
            WriteLine($"{ginny.Name} has {ginny.Children.Count} children.");
            WriteLine($"{cho.Name} has {cho.Children.Count} children");

            WriteLine(
                format: "{0}'s first child is named \"{1}\".",
                arg0: hermione.Name,
                arg1: hermione.Children[0].Name);
        }
    }
}