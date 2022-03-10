# Implementing Interfaces and Inheriting Classes
## Simplifying methods 
We might want two instances of `Person` to be able to procreate. We can implement this by writing methods. 
- Instance methods are actions that an object does to itself;
- Static methods are actions the type does. 

```cs
// static method to "multiply" 
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }
// instance method to "multiply"
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }
```
- In the `static` method named `Procreate`, the `Person` objects to procreate are passed as parameters named `p1` and `p2`. 
- A new `Person` class named `baby` is created with a name made of a combination of the two people who have procreated. 
- The `baby` object is added to the `Children` collection of both parents and then returned. 
    - Classes are reference types, meaning a reference to the `baby` object stored in memory is added, not a clone of the baby. 

- In the `instance` method named `ProcreateWith`, the `Person` object to procreate with is passed as a parameter named `partner`. 
    - And it, along with `this`, is passed to the static `Procreate` method to reuse the method implementation. 
    - `this` keyword that references the current instance of the class. 

### Good Practice 
> A method that creats a new object, or modifies an existing object, should return a reference to that object so that the caller can see the results. 