# Writing, Debugging, and Testing Functions
## Writing Functions 
>A fundamental principle of programming is **Don't Repeat Yourself (DRY)**
- Functions are like tiny programs that complete one small task. 

### In /Users/ajvigil/Desktop/code/csharp/book/chapter4/WritingFunctions/Program.cs
- Times Table Function
    - We have statically imported the `Console` type so that we can simplify calls to its methods such as `WriteLine`.
    - We have written a function named `TimesTable` that must have a `byte` value passed to it named `number`.
    - `TimesTable` does not return a value to the caller, so it is declared with the `void` keyword before its name. 
    - `TimesTable` uses a `for` statement to output the times table for the number passed to it. 
    - We have written a function named `RunTimesTable` that prompts the user to enter a number, and then calls `TimesTable`, passing it the entered number. 
        - It loops while the user enters valid numbers. 
    - We call `RunTimesTable` in the `Main` method. 
- Tax Function 
    - The `CalculateTax` function has two inputs:
        - A parameter named `amount` that will be the amount of money spent, and a parameter named `twoLetterRegionCode` that will be the region the amount is spent in. 
    - The `CalculateTax` function prompts the user to enter an amount and region code, and then calls `CalculateTax` and outputs the result. 
- Cardinal Function
    - The `CardinalToOrdinal` function has
        - one input: a parameter of the `int` type named `number`
        - one output: a return calue of the `string` type. 
    - A `switch` statement is used to handle the special cases of 11, 12, and 13. 
    - A nested `switch` statement then handles all other cases.
    - The `RunCardinalToOrdinal` function for each number and writing the returned string to the console, separated by a space character. 

