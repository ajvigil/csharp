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

## Debugging Windows
### Variables 
- Including **Locals**, which shows the name, value, and type for any local variables automatically. 
    - Keep an eye on this window while you step through your code. 
### Watch 
- Shows the value of variables and expressions that you manually enter. 
### Call Stack 
- Shows the stack of function calls. 
### Breakpoints
- Shows all your breakpoints and allows finer control over them. 
### Debug Console 
- Enables live interaction with your code. 
    - Example: You can ask a question such as, "What is 1+2?" by typing 1+2 and pressing _Enter_. 
- You can also interrogate the program state. 
    - Example: By entering the name of a variable. 

## Logging during development and runtime 
>There are two types that can be used to add simple logging to your code: `Debug` and `Trace`.
- `Debug` is used to add logging that gets written during development. 
- `Trace` is used to add logging that gets written during both development and runtime. 

The `Debug` and `Trace` classes can write to any **trace listener**. 
- A trace listener is a type that can be configured to write output anywhere you like when the `Trace.WriteLine` method is called. 

## Unit testing functions 
> Unit testing is a good way to find bugs early in the development process. 

### Writing unit tests 
A well-written unit test will have three parts: 
- **Arrange**: This part will declare and instantiate variables for input and output. 
- **Act**: This part will execute the unit that you are testing. 
- **Assert**: This part will make one or more assertions about the output. 
    - An assertion is a belief that if not true indicates a failed test. 

### End of Chapter Exercise 
- The `void` keyword is used in method signatures to declare a method that does not return a value. 
    - A method declared with the void return type cannot provide any arguments to any return statements they contain. 