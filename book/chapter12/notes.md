# Querying and Manipulating Data Using LINQ

LINQ has several parts; some are required, and some are optional:
- Extension methods (required)
    - These include examples such as `Where`, `OrderBy`, and `Select`. 
    - These are what provide the functionality of LINQ.
- LINQ providers (required)
    - These include LINQ to Objects, LINQ to Entities, LINQ to XML, LINQ to OData, and LINQ to Amazon.
    - These are what convert standard LINQ operations into specific commands for different types of data.
- Lambda expressions (optional)
    - These can be used instead of named methods to simplify LINQ extension method calls.
- LINQ query comprehension syntax (optional)
    - These include `from`, `in`, `where`, `orderby`, `descending`, and `select`. 
    - These are C# keywords that are aliases for some of the LINQ extension methods, and their use can simplify the queries you write, especially if you already have experience with other query languages such as SQL.

## Extending sequences with the Enumerable class

The LINQ extension methods, such as `Where` and `Select`, are appended by the `Enumberable` static class to any type, known as a **sequence**, that implements `IEnumerable<T>`.
- Example 
    - An array of any type implements the `IEnumerable<T>` class, where `T` is the type of item in the array, so all arrays support LINQ to query and manipulate them.

>  `Enumerable` defines more than 45 extension methods:

| Method(s) | Description |
| --------- | ----------- |
| `First`, `FirstOrDefault`, `Last`, `LastOrDefault` | Gets the first or last item in the sequence or returns the default for the type, for example, 0 for and `int`, `null` for a reference type, if there is no first or last item. |
| `Where` | Returns a sequence of items that match a specified filter. |
| `Single`, `SingleOrDefault` | Returns an item that matches a specific filter or throws an exception, or returns the default value for the type, if there is not exactly one match. |
| `ElementAt`, `ElementAtOrDefault` | Returns an item at a specified index position or throws an exception, or returns the default value for the type, if there is not an item at that position. |
| `Select`, `SelectMany` | Projects items into a different shape, that is, type, and flattens a nested hierarchy of items. |
| `OrderBy`, `OrderByDescending`, `ThenBy`, `ThenByDescending` | Sorts items by a specified property. |
| `Reverse` | Reverses the order of items. |
| `GroupBy`, `GroupJoin`, `Join` | Group and join sequences. |
| `Skip`, `SkipWhile` | Skip a number of items or skip while an expression is `true`. |
| `Aggregate`, `Average`, `Count`, `LongCount`, `Max`, `Min`, `Sum` | Calculates aggregate values. | 
| `All`, `Any`, `Contains` | Returns `true` if all of any of the items match the filter, or if the sequence contains a specified item. |
| `Cast` | Converts items into a specified type. |
| `OfType` | Removes items that do not match a specified type. | 
| `Except`, `Intersect`, `Union` | Performs operations that return sets. Sets cannot have duplicate items. Although the inputs of these methods can be any sequence so can have duplicates, the result is always a set. |
| `Append`, `Contcat`, `Prepend` | Performs sequence combining operations. |
| `Zip` | Performs a match operation based on the position of items. |
| `Distinct` | Removes duplicate items from the sequence. |
| `ToArray`, `ToList`, `ToDictionary`, `ToLookup` | Convert the sequence into an array or collection. |