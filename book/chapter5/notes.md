# Object-Oriented Programming 
> An object in programming often represents something in the real world, such as a product or bank account, but this can also be something more abstract. 
- In C#, we use the `class` (mostly) or `struct` (sometimes) keywords to define a type of object. 

## Concepts of object-oriented programming
- **Encapsulation** 
    - is the combination of the data and actions that are related to an object.
        - Example: a `BankAccount` type might have data, such as `Balance` and `AccountName`, as well as actions such as `Deposit` and `Withdraw`. 
    - When encapsulating, you often want to control what can access those actions and the data. 
        - Example: restricting how the internal state of an object can be accessed or modified from the outside. 
- **Composition** 
    - is about what an object is made of. 
        - Example: a car is composed of different parts, such as four wheels, several seats, and an engine. 
- **Aggregation**
    - is about what can be combined with an object. 
        - Example: a person is not part of a car object, but they could sit in the driver's seat and then becomes the car's driver. 
    - Two separate objects that are aggregated together to form a new component. 
- **Inheritance**
    - is about reusing code by having a subclass derive from a **base** or **super** class. 
    - All functionality in the base class is inherited by and becomes available in the derived class. 
        - Example: the base ir super `Exception` class has some members that have the same implementation across all exceptions.
        - The sub or derived `SqlException` class inherits those members and has extra members only relevant to when an SQL database exception occurs like a property for the database connection. 
- **Abstraction** 
    - is about capturing the core idea of an object and ignoring the details or specifics. 
    - C# has an `abstract` keyword which formalizes the concept. 
    - If a class is not explicitly `abstract` then it can be described as being concrete. 
    - Base or super classes are often abstract. 
        - Example: the super class `Stream` is `abstract` and its sub classes like `FileStream` and `MemoryStream` are concrete. 
    - Abstraction is a tricky balance. If you make a class more abstract, more classes would be able to inherit from it, but at the same time there will be less functionality to share. 
- **Polymorphism**
    - is about allowing a derived class to override an inherited action to provide custom behavior. 

## Building class libraries
> Class library assemblies group types together into easily deployable units (DDL files).
> - To make the code that you write reusable across multiple project, you should put it in class library assemblies. 

> The C# keyword `public` is applied before `class`.
- This keyword is called an **access modifier**, and it allows for all the other code to access this class.
    - If you do not explicitly apply the `public` keyword, then it would only be accessible within the assembly that defined it. 
        - This is because the implicit access modifer for a class is `internal`. We need this class to be accessible outside the assembly, so we must make sure it is `public`. 

```cs
//Example code for above
using System;

namespace Packt.Shared
{
    public class Person
    {

    }
}
```
---

## Understanding members
> Members can be fields, methods, or specialized versions of both. 

**Fields** are used to store data. There are three specialized categories:
- **Constant**
    - The data never changes. The compiler literally copies the data into any code that reads it. 
- **Read-only**
    - The data cannot change after the calss is instantiated, but the data can be calculated or loaded from an external source at the time of instantiation. 
- **Event**
    - The data references one or more methods that you want to execute when something happens, such as clicking on a button, or responding to a request from other code. 

**Methods** are used to execute statements. There are four specialized categories:
- **Constructor**
    - The statements execute when you use the `new` keyword to allocate memory and instantiate a class. 
- **Property**
    - The statements execute when you get or set data. The data is commonly stored in a field, but could be stored externally, or calculated at runtime. 
    - Properties are the preffered way to encapsulate fields unless the memory address of the field needs to be exposed. 
- **Indexer**
    - The statements execute when you get or set data using array syntax [].
- **Operator**
    - The statements execute when you use an operator like + and / on operands of your type. 