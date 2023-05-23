# Database info

## Database Info

- SQL Structured Query Language
- 1-n Tier Arachitecture
- Intergrated Data - relationship between tables
- Relationship, assioation between entities
- DBMS Database management system (oracle, SQl server)
  - security
  - integrity
  - quicker performance
- Itegrity Constraints
  - Enity integrity Constraints - Each entity needs a table and PF
  - Domain constraints - attributes from same domain
  - Referential integrity Constraints - if you have 2 tables have consistency constraint
  - Operation constraints

## Set up

1. Using SQL Server
   1. Open Microsoft SQL Server and conect
   2. Open 'Database' directory and create new database.
      1. Or you can create a file instead c# that can migrate to database.
   3. From here you can create tables in SQL code. Press execute
   4. You click edit top 200 rows to see the table information

```sql
    CREATE TABLE People (id INT IDENTITY (1, 1) PRIMARY KEY,
    name VARCHAR (100),
    age VARCHAR (3));

    INSERT INTO People(name, age) VALUES ('Rob', 25), ('John', 30), ('Sarah', 23), ('Tim', 40), ('Bill', 32);
```

## Linking database to C#

Using File 'DatabaseExamples'

1. Create file - console app, ASP
2. Using Nuget Extensions install Microsoft.Data.SqlClient
3. Include these 'using'

```cs
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
```

4. Declair a connection variable as a string `string connectionString = @"";`
5. Use teh SQlConnection class to pass in connection string `SqlConnection connection = new SqlConnection(connectionString);`
6. Then you can use `connection.Open()`
7. 

## Querying the database

1. IQueryable

- Doesnt need any data or objects that exist

2. IEnumerable

- This is already a collection
- Fixed data sets
- an object instance that exists
