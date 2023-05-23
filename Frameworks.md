# dotNet Framework Tools

## Table of contents

- [dotNet Framework Tools](#dotnet-framework-tools)
  - [Table of contents](#table-of-contents)
  - [Console app](#console-app)
  - [WPF Application](#wpf-application)
    - [Click event](#click-event)
  - [.Net web API](#net-web-api)
  - [Forms](#forms)

## Console app

- multiplatorm w,l,a

## WPF Application

- Windows Presentation Foundation (WPF)
- For creating a app model that works on windows.
- The window use XAML code
- Let's break down this XAML code to understand it better. XAML is simply XML that can be processed by the compilers that WPF uses. It describes the WPF UI and interacts with .NET code. To understand XAML, you should, at a minimum, be familiar with the basics of XML.

WPF, or Windows Presentation Foundation, is a UI (user interface) framework that creates desktop client applications. The WPF development platform supports a broad set of application development features, including an application model, resources, controls, graphics, layout, data binding, documents, and security.

WPF is part of .NET, so if you have previously built applications with .NET using ASP.NET or Windows Forms, the programming experience should be familiar. WPF uses the Extensible Application Markup Language XAML to provide a declarative model for application programming. For more information, see WPF .NET overview.

```cs
<Window x:Class="Names.LayoutStep2"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Names"
        mc:Ignorable="d"
        Title="Names" Height="180" Width="260">
    <Grid Margin="10">

        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>

        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="*" />
        </Grid.ColumnDefinitions>

    </Grid>
</Window>
```

### Click event

```cs
<StackPanel Grid.Row="1" Grid.Column="1" Margin="5,0,0,0">
    <TextBox x:Name="txtName" />
    <Button x:Name="btnAdd" Margin="0,5,0,0" Click="ButtonAddName_Click">Add Name</Button>
</StackPanel>


// In main csharp project file
private void ButtonAddName_Click(object sender, RoutedEventArgs e)
{

}
```

## .Net web API

- `dotnet new sln -o BuberBreakfast` create
- `cd BuberBreakfast`
- `dotnet new classlib -o BuberBreakfast.Contracts`
- `dotnet new webapi -o BuberBreakfast` install api
- `dotnet build` then get error message because the files are not installed
- `dotnet sln add .\BuberBreakfast.Contracts\ .\BuberBreakfast\` to install

1. Create controllers for database

```cs
   public record BreakfastResponse(
    Guid Id,
    string Name,
    sting Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<String> Savory,
    List<String> Sweet
    );

```

## Forms

Windows Forms, a UI framework that creates rich desktop client apps for Windows. The Windows Forms development platform supports a broad set of app development features, including controls, graphics, data binding, and user input. Windows Forms features a drag-and-drop visual designer in Visual Studio to easily create Windows Forms apps.

1. Add a form item from Toolbox menu
2. Name the item

Now that we've added a button control to create an action, let's add a label control to send text to.

    Select the Label control from the Toolbox window, and then drag it onto the form and drop it beneath the Click this button.

    In either the Design section or the (DataBindings) section of the Properties window, change the name of label1 to lblHelloWorld, and then press Enter.

3.
