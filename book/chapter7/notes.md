# Understanding and Packaging .NET Types
## Understanding .NET Core componenets 
.NET Core is made up of several pieces, which are as follows 

**Language compilers**:
- These turn your source code written with languages such as C#, F#, and Visual Basic into **intermediate language (IL)** code stored in assemblies. 

**Common Language Runtime (CoreCLR)**:
- This runtime loads, assemblies, compiles the IL code stored in them into native code instructions for your computer's CPU, and executes the code within an environment that manages resources such as threads and memory. 

**Base Class Libraries (BCL) of assemblies in NuGet packages (CoreFX)**:
- These are prebuilt assemblies of types packaged and distributed using NuGet for performing common tasks when building applications. 

---
## Understanding assemblies, packages, and namespaces 
An **assembly** is where a type is stored in the filesystem. 
- Assemblies are a mechanism for deploying code. 

> Assemblies are often distributed as **NuGet packages**, which can contain multiple assemblies and other resources. 

A **namespace** is the address of a type. 
- Namespaces are a mechanism to uniquely identify a type by requiring a full address rather than just a short name. 

---
## Understanding dotnet commands 
**Managing projects**
The `dotnet` CLI has the following commands that work on the project in the current folder, to manage the project:
- `dotnet restore`: this downloads dependencies for the project.
- `dotnet build`: this compiles the project. 
- `dotnet test`: this runs unit tests on the project. 
- `dotnet run`: this runs the project. 
- `dotnet pack`: this creates a NuGet package for the project. 
- `dotnet publish`: this compiles and then publishes the project, either with dependencies or as a self-contained application. 
- `add`: this adds a reference to a package or class library to the project. 
- `remove`: this removes a reference to a package or class library from the project. 
- `list`: this lists the package or class library references for the project.  
