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

--- 
---
## Implementing functionality using operators 
The `System.String` class has a static method named `Concat` that concatenates two `string` values and returns the result. 

```cs 
string s1 = "Hello ";
string s2 = "World!";
string s3 = string.Concat(s1, s2);
WriteLine(s3); // => Hello World!
```

Calling a method like Concat works, but it might be more natural for a programmer to use the + symbol to add two string values together.

```cs
string s1 = "Hello ";
string s2 = "World!";
string s3 = s1 + s2;
WriteLine(s3); // => Hello World!
```

> ### Good practice: 
> - Unlike methods, operators do not appear in IntelliSense lists for a type. 
> - For every operator you define, make a method as well, because it may not be obvious to a programmer that the operator is available. 

---
---
## Implementing functionality using local functions 

Local functions are the method equivalent of local variables. 
- They are methods that are only accessible from within the containing method in which they have been defined. 
- In other languages, they are sometimes called **nested** or **inner functions**. 
> Local functions can be defined anywhere inside a method. 

---
---
## Raising and handling events 

**Methods** are often described as _actions that an object can perform, either on itself or to related objects_. 
- Example: `List` can add an item to itself or clear itself, and `File` can create or delete a file in the filesystem. 

**Events** are often described as _actions that happen to an object_. 
- Example: in a UI, `Button` has a `Click` event, click being something that happens to a button. 
- Another way of thinking of events is that they provide a way of exchanging messages between two objects. 

--- 
## Calling methods using delegates 

The other way to call or execute a method is to use a **delegate**. 
- A delegate contains the memory address of a method that matches the same signature as the delegate so that it can be called safely with the correct parameter types. 

We would use delegates to create a queue of methods that need to be called in order. 

Another example is to allow multiple actions to perform in parallel. 
- Delegates have built-in support for asynchronous operations that run on a different threa, and that can provide improved responsiveness. 

> Microsoft has two predefined delegates for use as events. Their signatures are simple, yet flexible. 
```cs 
public delegate void EventHandler(
    object sender, EventArgs e);

public delegate void EventHandler<TEventArgs>(
    object sender, TEventArgs e);
```
---
---
## Implementing interfaces 

Interfaces are a way of connecting different types together to make new things. 
> Think of them like the studs on top of LEGOs which allow them to "stick" together. 

### Common interfaces 

| Interface | Method(s) | Description |
| --------- | --------- | ----------- |
| **IComparable** | `CompareTo(other)` | This defines a comparasion method that a type implements to order or sort its instances. |
| **IComparer** | `Compare(first, second)` | This defines a comparasion method that a secondary type implements to order or sort instances of a primary type. |
| **IDisposable** | `Dispose()` | This defines a disposl method to release unmanaged resources more efficiently than waiting for a finalizer. |
| **IFormattable** | `ToString(format, culture)` | This defines a culture-aware method to format the value of an object into a string representation. |
| **IFormatter** | `Serialize(stream, object)` and `Deserialize(stream)` | This defines methods to convert an object to and from a stream of bytes for storage or transfer. |
| **IFormatProvider** | `GetFormat(type)` | This defines a method to format inputs based on a language and region. |

One of the most common is `IComparable`
- It allows arrays and collections of any type that implements it to be stored. 