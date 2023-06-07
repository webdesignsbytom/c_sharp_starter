# c_sharp_starter

A repo and instruction list for new projects and general c# data and code lines

## Table of contents

- [c\_sharp\_starter](#c_sharp_starter)
  - [Table of contents](#table-of-contents)
  - [General info](#general-info)
  - [Technologies](#technologies)
  - [How to install](#how-to-install)
  - [Start a new project](#start-a-new-project)
  - [Architechture](#architechture)
  - [Snippets](#snippets)
  - [Classes](#classes)
  - [.NET Framework](#net-framework)
  - [Packages and their uses](#packages-and-their-uses)
    - [ASP](#asp)
    - [MVC MODELS VIEWS CONTROLLERS](#mvc-models-views-controllers)
    - [Found errors](#found-errors)
    - [Shortcuts](#shortcuts)

## General info

## Technologies

App developed with:

C# || C Sharp
.net
Using CLR common runtime language

## How to install

## Start a new project

- `dotnet new console` Start a new project
- `dotnet build` build file after editing
- `dotnet run` run the project

## Architechture

- Assembly (DLL or EXE)
  - Namespace (dir name)
    - Classes
      - Data
      - Method

## Snippets

- `System.Diagnostics.Debug.WriteLine(b);` Test code
- `Console.WriteLine(b);` Print Code
- `Ex1 ex1Object = new Ex1();` Create new object

## Classes

- `public class Ex1 { }`
  `public class Ex2 : Ex1 { }` extend a class

## .NET Framework

- A C# and F# solution to making multip platform projects
- A virtual framwork like java
-

## Packages and their uses

1. ASP
2. MVC
3. FORMS
4. CONSOLE APP - no gui. Text based programmable app.
5. WPF
6. MVVM Model view view model

### ASP

- ASP.NET is a server side and web applications
- The best tool to use is C# but you can use many languages.
- A solution to build web forms
- Runs a dynamic website
- `Razor` is the dymanic code that runs the front end and is cross between html an css
- Pages folders are for Razor not MVC
- `Entity` is the ORM object relation mapper for databases for basic apps.
- `.cshtml` is the file extension.
- Using bootstrap classes as style.
- Can work with React, angular and vuew.
- IIS is microsofts web server and used to run locally
- Views folder containers html and frontend
- MAUI croos platform
- WinForms - older form version and is being phased out. Legacy code.

### MVC MODELS VIEWS CONTROLLERS

A code process to create smaller modules that a reuseable.
Sperations of concerns with smaller file sizes.

- Models, manage data and behavior
- Views, manage the display of data. Dynamic cshtml.
- Controller, handles page events and navigation.

Structure Users => Router => Controller => Models => Database

Create controller

1. Right click controllers dir
2. Add controller
3. Select 3rd option
4. Route it to ApplicationDbContext
5. All tick boxes
6. Press Add

### Found errors

- localhost blocked by google go to
  chrome://flags/ then set local hosts Allow invalid certificates for resources loaded from localhost.

### Shortcuts

- quick property `prop + tab + tab`
- quick contructor, `ctor + tab + tab`, public Name {} method
- `propfull + tab + tab`
- `ctrl D` duplicate
- `ctrl shift b` build file
- `ctrl .` shortcut to create stuff
- `ctor + tab + tab` create public constructor 
