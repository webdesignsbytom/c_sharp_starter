# ASP dotNet Framework

## Table of contents

- [ASP dotNet Framework](#asp-dotnet-framework)
  - [Table of contents](#table-of-contents)
  - [What is ASP.NET Framework](#what-is-aspnet-framework)
  - [ASP](#asp)
  - [The langauge](#the-langauge)
  - [Start a project](#start-a-project)
  - [Database](#database)
  - [File Architecture](#file-architecture)
    - [Attributes](#attributes)

## What is ASP.NET Framework

This is a open source web framework for secure apps that run on all platforms;

- uses html css js
- web and mobile app
- microsoft will verify your project

## ASP

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

## The langauge

Razor

- Razor is a combo of html and c#
- html@ and then add c#

## Start a project

- ASP.NET Core Web APP

## Database

Can be a:

- Static (items.json)
- File
- A SQL Database

## File Architecture

- Project
  - Properties
  - wwwroot
  - Pages
  - Models (c#)
  - Program.cs

### Attributes

[JsonPropertyName] - access json

```cs
namespace EtsyWebApp.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }
        // Map img to image
        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Rating { get; set; }

        // Override the 2 string method
        public override string ToString()
        {
            // Serial means one after the other
            return JsonSerializer.Serialize<Product>(this);
        }
    }
}
```
