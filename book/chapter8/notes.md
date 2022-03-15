# Working with Common .NET Types

## Working with numbers 
| Namespace | Example type(s) | Description |
| --------- | --------------- | ----------- |
| **System** | `Sbyte`, `Int16`, `Int32`, `Int64` | Integers;zero and positive and negative whole numbers. |
| **System** | `Byte`, `UInt16`, `UInt32`, `UInt64` | Cardinals; zero and positive whole numbers. |
| **System** | `Single`, `Double` | Reals; floating point numbers. |
| **System** | `Decimal` | Accurate reals; for use in science, engineering, or financial scenarios. |
| **System.Numerics** | `BitInteger`, `Complex`, `Quaternion` | Arbitrarily large inegers, complex numbers, and quaternion numbers. |

## Working with text

| Namespace | Type | Description |
| --------- | ---- | ----------- |
| **System** | `Char` | Storage for a single text character. |
| **System** | `String` | Storage for multiple text characters. |
| **System.Text** | `StringBuilder` | Efficiently manipulates strings. |
| **System.Text.RegularExpressions** | `Regex` | Efficiently pattern-matches strings. |

## Getting part of a string
Sometimes you need to get part of some text. 
- The `IndexOf` method has nine overloads that return the index position of a specified `char` or `string`.
- The `Substring` method has two overloads. 
    - `Substring(startIndex, length)`: returns a substring starting at `startIndex` and containing the next length characters.
    - `Substring(startIndex)`: returns a substring starting at `startIndex` and containing all characters up to the end of the string.

## Checking a string for content
Sometimes you need to check whether a piece of text starts or ends with some characters or contains some characters. 
- You can achieve this with methods named  `StartsWith`, `EndsWith`, and `Contains`

## Joining, formatting, and other string members

| Member | Description |
| ------ | ----------- |
| `Trim`, `TrimStart`, and `TrimEnd` | These trim whitespace characters such as space, tab, and carriage-return from the beginning and/or end of the `string` variable. |
| `ToUpper` and `ToLower` | These convert all the characters in the `string` variable into uppercase or lowercase. |
| `Insert` and `Remove` | These insert or remove some text with other text. |
| `Replace` | This replaces some text with other text. |
| `string.Concat` | This concatenates two `string` variables. The + operator calls this method when used between `string` variables. |
| `string.Join` | This concatenates one or more `string` variables with a character between each one. |
| `string.IsNullOrEmpty` | This checks whether a `string` variable is `null` or empty (""). |
| `string.IsNullOrWhitespace` | This checks whether a  `string` variable is `null` or whitespace; that is, a mix of any number of horizontal and vertical spacing characters, for example, tab, space, carriage return, line feed, and so on. |
| `string.Empty` | This can be used instead of allocating memory each time you use a literal `string` value using an empty pair of double quotes (""). |
| `string.Format` | An older, alternative method to string interpolation to output formatted `string` variables, which uses positioned instead of named parameters. |

Some methods are `static` methods. This means that the method can only be called from the type, not from a variable instance. 

## Understanding the syntax of a regular expression
Here are some common regular expressions **symbols** that you can use in regular expressions:

| Symbol | Meaning | Symbol | Meaning |
| ------ | ------- | ------ | ------- |
| ^ | Start of input | $ | End of input |
| \d | A single digit | \D | A single NON-digit |
| \w | Whitespace | \W | NON-whitespace |
| [A-Za-z0-9] | Range(s) of characters | \^ | ^(caret) character |
| [aeiou] | Set of characters | [^aeiou] | NOT in a set of characters |
| . | Any single character | \\. | .(dot) character |

In addition, here are some regular expression **quantifiers** that affect previous symbols in a regular expression:

| Symbol | Meaning | Symbol | Meaning |
| ------ | ------- | ------ | ------- |
| + | One or more | ? | One or more |
| {3} | Exactly three | {3, 5} | Three to five |
| {3,} | At least three | {, 3} | Up to three |

## Examples of regular expressions

| Expression | Meaning | 
| ---------- | ------- |
| \d | A single digit somewhere in the input |
| a| The character `a` somewhere in the input |
| Bob | The word `Bob` somewhere in the input | 
| ^Bob | The word `Bob` at the start of the input |
| Bob$ | The word `Bob` at the end of the input |
| ^\d{2}$ | Exactly two digits |
| ^[0-9]{2}$ | Exactly two digits |
| ^[A-Z]{4, }$ | At least four uppercase English letters in the ASCII character set only |
| ^[A-Za-z]{4, }$ | At least four upper or lowercase English letters in the ASCII character set only |
| ^[A-Z]{2}\d{3}$ | Two uppercase English letters in the ASCII character set and three digits only |
| ^[A-Za-z\u00c0-\u017e]+$ | At least one uppercase or lowercase English letter in the ASCII character set or European letters in the Unicode set. |
| ^d.g$ | The letter `d`, then any character, and then the letter `g`, so it would match both `dig` and `dog` or any single character between the `d` and `g` |
| ^d\\.g$ | The letter `d`, then a dot (.), then the letter `g`, so it would match d.g only |

> **Good Practice**: Use regular expressions to validate input from the user.
> - The same regular expressions can be reused in other languages such as JavaScript.

## Storing multiple objects in collections

A **collection** is a data structure in memory that can manage multiple items in different ways, although all collections have some shared functionality.

| Namespace | Example type(s) | Description |
| --------- | --------------- | ----------- | 
| System.Collections | `IEnumerable`, `IEnumberable<T>` | Interfaces and base classes used by collections. |
| System.Collections.Generic | `List<T>`, `Dictionary<T>`, `Queue<T>`, `Stack<T>` | Introduced in C# with .NET Framework 2.0. These collections allow you to specify the type you want to store using a generic type parameter (which is safer, faster, and more efficient). |
| System.Collections.Concurent | `BlockingCollection`, `ConcurrentDictionary`, `ConcurrentQueue` | These collections are safe to use in multithreaded scenarios. |
| System.Collections.Immutable | `ImmutableArray`, `ImmutableDictionary`, `ImmutableList`, `ImmutableQueue` | Designed for scenarios where the contents of the original collection never change, although they can create modified collections as a new instance. | 


## Understanding collection choices 

**Lists** are a good choice when you want to manually control the order of items in a collection.
- Each item in a list has a unique index (or position) that is automatically assigned. 
- Items can be any type defined by `T` and items can be duplicated. 
- Indexes are `int` types and start from 0. 

**Dictionaries** are a good choice when each value (or object) has a unique sub value (or a made-up value) that can be used as a _key_ to quickly find the value in the collection later.
- The key must be unique. 

**Stacks** are a good choice when you want to implement the _last-in, first-out (LIFO)_ behavior.
- With a stack, you can only directly access or remove the one item at the top of the stack, although you can enumerate to read through the whole stack of items. 

**Queues** are a good choice when you want to implement the _first-in, first-out (FIFO)_ behavior.
- With a queue, you can only directly access or remove the one item at the front of the queue.

**Sets** are a good choice when you want to perform set operations between two collections. 

