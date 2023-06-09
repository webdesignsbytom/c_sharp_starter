# SQL

## Table of contents

- [SQL](#sql)
  - [Table of contents](#table-of-contents)
  - [Installation](#installation)
  - [Using SQL Server Management Studio](#using-sql-server-management-studio)
  - [Datatypes](#datatypes)
  - [KEYWORDS](#keywords)
  - [Quick Code](#quick-code)

## Installation

1. Download SQL server management tool - where you write sql code
2. Install SQL server - sql express / dev edition. A database for storing info

## Using SQL Server Management Studio

Open databases and hit write query to use sql code
If you have a db open make sure its selected on the top left drop down - it may say 'master' or ```use [name]```
Reset itellisense cashe

## Datatypes

- VarChar
- Int

## KEYWORDS

- DISTINCT - removes doubles
- JOIN
  - INNER
  - LEFT
  - RIGHT
  - FULL

## Quick Code

Basic lines to set up a database

```js

// Adds db to explorer
create database Customer
// selects database to use
use Customer
// Create table
create table Customer
(
	FirstName VarChar(50),
	LastName VarChar(50),
	Age Int
)
// Insert a row of data
insert into dbo.Customer
(FirstName, LastName, Age)
	values ('tom', 'green', 40);
// Select all data from table
select * from Customer
// select some data from table
select FirstName,LastName from Customer
// select data with values
select FirstName,LastName
from Customer
where FirstName = 'tom'
// select data with multiple valuesSELECT * FROM movies;
select FirstName,LastName
from Customer
where FirstName = 'tom'
and LastName = 'green'
// select data with close to same values
select FirstName,LastName
from Customer
where FirstName = 'tom' // i.e starts with t = t%
and LastName like 'gre%'
// UPDATES
// Update a col value
select FirstName,LastName,Age
from Customer
where FirstName = 'tom'
and LastName = 'greener'

update Customer 
Set Age = 1
where FirstName = 'tom'
and LastName = 'greener';

// DELETE
// Delete all rows
DELETE Customer;
// Delete targeted data

// JOIN TABELS
SELECT title, domestic_sales, international_sales, rating 
FROM movies
  JOIN boxoffice
    ON movies.id = boxoffice.movie_id;

// With where clause
SELECT title, domestic_sales, international_sales
FROM movies
  JOIN boxoffice
    ON movies.id = boxoffice.movie_id
WHERE international_sales > domestic_sales;

