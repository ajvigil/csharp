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

--- 
## Understanding access modifiers 
> Part of encapsulation is choosing how visible the members are. 
- There are four access modifer keywords, and two combinations of access modifer keywords that you can apply to a class member, such as a field or method as shown below in the table. 

| **Access Modifier** | **Description** |
| ------------------- | --------------- |
| `private` | Member is accessible inside the type only. This is the default. |
| `internal` | Member is accessible inside the type and any type in the same assembly. |
| `protected` | Member is accessible inside the type and any type that inherits from the type. |
| `public` | Member is accessible everywhere. |
| `internal protected` | Member is accessible inside the type, any type in the same assembly, and any type that inherits from the type. |
| `private protected` | Member is accessible inside the type, or any type that inherits from the type and is in the same assembly. |

> ### **Good Practice**:
> - Explicitly apply one of the access modifiers to all type members, even if you want to use the implicit access modifier for members, which is `private`. 
> - Additionally, fields should usually be `private` or `protected`, and you should then create `public` properties to get or set the field values.
>   - This is because it controls access. 

---
## Storing a value using an enum type 
> Sometimes a value needs to be one of a limited set of options. 
> - We are able to store this data by defining an `enum` type. 

An `enum` type is a very efficient way of storing one or more choices because, internally, it uses integer values in combination with a lookup table of `string` descriptions. 
- The `enum` value is internally stored as an `int` for efficiency. 

## Storing multiple values using an enum type
> We can combine multiple choices into a single value using **flags**.

---
## Making a field static 
> Sometimes you want to define a field that only has one value that is shared across all instances. 
> - These are called **static** members because fields are not the only members that can be `static`.

## Making a field constant 
> If the value of a field will never _ever_ change, you can use the `const` keyword and assign a literal value at compile time. 

### Good practice 
- Constants should be avoided for two important reasons: 
    - The value must be known at compile time, and it bust be expressible as a literal string, Boolean, or number value. 
- Every reference to the `const` field is replaced with the literal value at compile time, which will, therefore, not be reflected if the value changes in a future version and you do not recompile any assemblies that reference it to get the new value. 

## Making a field read-only
> A better choice is for fields that should not change is to mark them as read-only. 

Use read-only files over the `const` fields for two important reasons:
- The value can be calculated or loaded at runtime and can be expressed using any executable statement. 
    - A read-only field can be set using a constructor or a field assignment. Every reference to the field is a live reference, so any future changes will be correctly reflected by calling code. 

## Writing and calling methods 
> **Methods** are members of a type that execute a block of statements. 

- Methods can return a single value or return nothing. 
    - A method that performs some actions but does not return a value indicatees this with the `void` type before the name of the method. 
    - A method that performs some actions and returns a value indicates this with the type of the retrun value before the name of the method. 

## Combining multiple returned values using tuples
> Each method can only return a single calue that has a single type. 
> - That type could be a simple type, such as `string` or a complex type, such as `Person`, or a collection type, such as `List<Person>`.

## Defining and passing parameters to methods 
> Methods can have parameters passed to them to change their behavior. 
> - Parameters are defined a bit like variable declarations, but inside the parentheses of the method. 

Another way to simplify methods is to make parameters optional. 
- You make a parameter optional by assigning a default value inside the method parameter list. 
- Optional parameters must always come last in the list of parameters. 

## Controlling how parameters are passed 
When a parameter is passed into a method, it can be passed one of three ways:
- By **value** (this is the default): Think of these as being _in-only_.
- By **reference** as a `ref` parameter: Think of these as being _in-and-out_.
- AS an `out` parameter: Think of these as being _out-only_.

## Controlling access with properties and indexers
> A **property** is simply a method (or a pair of methods) that acts and looks like a field when you want to get or set a value, thereby simplifying the syntax. 

A `readonly` property only has a `get` implementation. 

## Defining indexers 
> Indexers allow the calling code to use the array syntax to access a property. 
- Example: 
    - The `string` type defines an **indexer** so that the calling code can access individual characters in the `string` individually. 
