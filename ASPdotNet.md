# ASP dotNet Framework

## Table of contents

- [ASP dotNet Framework](#asp-dotnet-framework)
  - [Table of contents](#table-of-contents)
  - [What is ASP.NET Framework](#what-is-aspnet-framework)
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
