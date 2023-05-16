# .Net Framework Tools

## Console app

- multiplatorm w,l,a

## WPF Application

- Windows Presentation Foundation (WPF)
- For creating a app model that works on windows.
- The window use XAML code
- Let's break down this XAML code to understand it better. XAML is simply XML that can be processed by the compilers that WPF uses. It describes the WPF UI and interacts with .NET code. To understand XAML, you should, at a minimum, be familiar with the basics of XML.

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

## Click event

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
