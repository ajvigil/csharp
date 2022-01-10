# Fundamentals 
## Compilers vs Interpreters 
### Compiler 
- Translates the compiler source program in a single line.
    - Faster
    - Consumes less time
    - More efficient
- Compiler languages include
    - C++
    - C#
    - TypeScript
### Interpreter 
- Translates the source program line by line
    - slower
    - consumes more time 
    - less efficient
- Interpreter languages include 
    - Python
    - PHP
    - JavaScript

## Solutions 
- One solution can contain multiple projects.

## Types and Variables
### int 
```cs 
int x = 2; 
Console.WriteLine("Number x is" + x);
```
Just like javascript the + will concatenate the two. 

### double
```cs 
double DoubleNum = 0.0d;
```
### float 
```cs 
float FloatNum = 0.0f;
```
### decimal 
```cs
decimal DecimalNum = 0.0m;
```

To declare a cariable you specify the data type and the variable name followed by a value. 

```cs
DataType variableName = value;
```
### Naming Rules 
- variable must start with underscore or letter
- variables cannot contain spaces
- variable can contain numbers 
- cannot contain symboles except underscore

## Arrays 
Arrays are similar to variable but can hole more than one value. 

### Syntax 
```cs
DataType[] ArrayName = {Comma Seperated Values}//Array of any size
```
```cs
DataType[] ArrayName = new DataType[3] {comma seperated values} //expects 3 values 
```

### Examples 
```cs 
string[] MyGamesOf2013 = {"GATV", "Battlfield3"};

string[] MyMoviesOf2013 = new string [3] {"The Amazing Spiderman", "The Expendables 2", "Rise of the plant of the apes"};
```
