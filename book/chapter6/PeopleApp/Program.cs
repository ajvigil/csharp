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
            
            // working with struct types 
            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;
            WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

            // inheriting classes 
            Employee john = new Employee
            {
                Name = "John Jones",
                DateOfBirth = new DateTime(1990, 7, 28)
            };
            john.WriteToConsole();

            // extending classes 
            john.EmployeeCode = "JJ001";
            john.HireDate = new DateTime(2014, 11, 23);
            WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

            //overriding members
            WriteLine(john.ToString());

            // understanding polymorphism
            Employee aliceInEmployee = new Employee
                { Name = "Alice", EmployeeCode = "AA123" };

            Person aliceInPerson = aliceInEmployee;

            aliceInEmployee.WriteToConsole();

            aliceInPerson.WriteToConsole();

            WriteLine(aliceInEmployee.ToString());

            WriteLine(aliceInPerson.ToString());

            // Explicit casting 
            if (aliceInPerson is Employee)
            {
                WriteLine($"{nameof(aliceInPerson)} IS an Employee");

                Employee explicitAlice = (Employee)aliceInPerson;
                // safely do something with explicitAlice 
            }

            Employee aliceAsEmployee = aliceInPerson as Employee;

            if (aliceAsEmployee != null)
            {
                WriteLine($"{nameof(aliceInPerson)} AS an Employee");
                // do something with aliceInEmployee 
            }

            // inheriting expceptions
            try
            {
                john.TimeTravel(new DateTime(1999, 12, 31));
                john.TimeTravel(new DateTime(1950, 12, 25));
            }
            catch (PersonException ex)
            {
                WriteLine(ex.Message);
            }

            // using static methods to reuse functionality 
            string email1 = "pamela@test.com";
            string email2 = "ian&test.com";

            WriteLine(
                "{0} is a valid e-mail address: {1}",
                arg0: email1,
                arg1: StringExtensions.IsValidEmail(email1));

            WriteLine(
                "{0} is a valid e-mail address: {1}",
                arg0: email2,
                arg1: StringExtensions.IsValidEmail(email2));

            WriteLine(
                "{0} is a valid e-mail address: {1}",
                arg0: email1,
                arg1: email1.IsValidEmail());

            WriteLine(
                "{0} is a valid e-mail address: {1}",
                arg0: email2,
                arg1: email2.IsValidEmail());
        }
        private static void Hermione_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }
    }
}