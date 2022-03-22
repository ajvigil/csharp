# Working with Databases Using Entity Framework Core

## Understanding modern databases
Two of the most common places to store data are in a **Relational Database Management System (RDBMS)** such as MicrosoftSQL Server, PostgreSQL, MySQL, and SQLite, or in a **NoSQL** data store such as Microsoft Azure Cosmos DB, Redis, MongoDB, and Apache Cassandra. 

---
## Understanding Entity Framework
ORMs use a mapping definition to associate columns in tables to properties in classes. 
- Then, a programmer can interact with objects of different types in a way that they are familiar with, instead of having to deal with knowing how to store the values in a relational table or other structure provided by a NoSQL data store.

-- 
## Defining EF Core models 
EF Core uses a combination of **conventions**, **annotation attributes**, and **Fluent API** statements to build an entity model at runtime so that any actions performed on the classes can later be automatically translated into actions performed on the actual database. 
- An entity represents the structure of a table and an instance of the class represents a row in that table.
--
### EF Core conventions
- The name of a table is assumed to match the name of a `DbSet<T>` property in the `DbContext` class.
- The names of the columns are assumed to match the names of properties in the class.
- The `string` .NET type is assumed to be a `nvarchar` type in the database.
- A property that is named `ID`, or if the class is named `Product`, then the property can be named `ProductID`.
    - That property is then assumed to be a primary key. 

--- 
There are three **loading patterns** that are commonly used with EF:
- lazy loading
- eager loading
- explicit loading