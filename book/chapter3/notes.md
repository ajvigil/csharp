# controlling flow and coverting types 

## operating on variables 
 
 > **operators** apply simple operations such as addition and multiplication to **operands** such as variables and literal values. 

- most operators are binary, meaning that they work on two operands, as shown in the following pseudocode

```cs
var resultOfOperation = firstOperand operator secondOperand;
```

- some operators are unary, meaning they work on a single operand, and can apply before or after the operand, as shown. 

```cs
var resultOfOperation = onlyOperand operator;
var resultOfOperation2 = operator onlyOperand;
```

## logical operators 
> **logical operators** operate on boolean values, so they return `true` or `false`

## bitwise and binary shift operators 
- Bitwise operators effect the bits in number. 
- Binary shift operators can perform some common arithmetic calculations much faster than traditional operators. 

```cs 
 int a = 10; //0000 1010
        int b = 6; //0000 0110

        WriteLine($"a = {a}");
        WriteLine($"b = {b}");
        WriteLine($"a & b = {a & b}"); //2-bit column only
        WriteLine($"s | b = {a | b}"); //8, 4, and 2-bit columns
        WriteLine($"a ^ b = {a ^ b}"); //8 and 4-bit columns

        // 0101 0000 left-shift a by three but columns 
        WriteLine($"a << 3 = {a << 3}");

        //multiply a by 8
        WriteLine($"a * 8 = {a * 8}");

        // 0000 0011 right-shift b by one bit column
        WriteLine($"b >> 1 = {b >> 1}");

```

Output is when ran
```cs
a << 3 = 80
a * 8 = 80
b >> 1 = 3
```

- The `80` result is because the bits in it were shifted three columns to the left, so 1-bits moved into the 64- and 16-bit columns and 64 + 16 = 80. 
    - This is the equivalent of multiplying by `8` but CPUs can perform a bit-shift faster. 
- The `3` result is because the 1-bits in `b` were shifted one column into the 2- and 1-bit columns.

## Miscellaneous operators 
> `nameof` and `sizeof` are convenient operators when working with types. 

`nameof` returns the short name (without namespace) of variable, type, or member as a string value. 
- Which is useful when outputting exception messages. 

`sizeof` returns the size in bytes of simple types. 
- Which is useful for determining efficiency of data storage. 

>There are many other operators
- Examples
    - the dot between a variable and its members is called the **member accesss operator**
    - The round brackets at the end of a function or method name is called the **invocation operator** as shown below. 

```cs 
int age = 47
//How many operators in the following statement? 

string firstDigit = age.ToString()[0];
```

There are four operators: 
- `=` is the **assignment operator**
- `.` is the **member access operator**
- `()` is the **invocation operator** 
- `[]` is the **indexer access operator**

## Understating selection statements 

> Every applicaiton needs to be able to select from choices and branch along different code paths. 
- In C# the two selection statements are `if` and `switch`. 
    - You can use `if` for all your code, but `switch` can simplify your code in some common scenarios. 

## Branching with the if statement 
> The `if` statement determines which branch to follow by evaluating a Boolean expression. 

>> If the expression is `true` then the block executes. 

>> The `else` block is optional and it executes if the `if` expression is `false`. 

Examples 

```cs
if (expression1)
{
    //runs if expression is true
}
else if (expression2)
{
    //runs if expression1 is false and expression2 if true
}
else if (expression3)
{
    //runs if expression1 and expression2 are false
    //and expression3 is true
}
else
{
    //runs if all expressions are false
}
```

- **pattern matching**
    - The `if` statement can use the `is` keyword in combination with declaring a local variable to make your code safer. 

## Branching with the switch statment

> The `switch` statement is different from the `if` statement because it compares a single expression against a list of multiple possible `case` statements. 
- Every `case` statement is related to the single expression. 
- Every `case` section must end with: 
    - The `break` keyword (case 1 in switch folder code)
    - Or the `goto case` keywords (case 2 in switch folder code)
    - Or they should have no statements (case 3 in switch folder code)


## Understanding iteration statements 
> Iteration statements repeat a block of statemetns either while a condition is true or for each item in a collection. 
- The choice of which statemetn to use is based on a combination of ease of understanding to solve the logic and problem and personal preference. 