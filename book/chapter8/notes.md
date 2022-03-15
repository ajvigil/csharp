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