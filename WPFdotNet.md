# WPF

- Windows Presentation Foundation (WPF)
- Created as a UI framework with Windows Desktop Apps.
- For creating a app model that works on windows.
- The window uses XAML code

## Table of contents

- [WPF](#wpf)
  - [Table of contents](#table-of-contents)
  - [About WPF](#about-wpf)
  - [Set up](#set-up)
  - [MVVM](#mvvm)
  - [Buttons](#buttons)
  - [Bindings](#bindings)
  - [Grid](#grid)
  - [StackPanel](#stackpanel)
  - [GridSplitter](#gridsplitter)
  - [XAML](#xaml)
  - [Adding Style](#adding-style)
    - [Style Examples](#style-examples)
  - [Functions](#functions)
    - [Examples](#examples)
    - [Opening a new window](#opening-a-new-window)

## About WPF

Overview
Instead of a user interacting with the console. A UI is created using XAML code.

What you get?

- Animations
- text and buttons
- password fields
- create custom controls

When/Why you may use it?

- Less front end work than a ASP app
- Not browser limited
- using all c# packages
- Easy to start
- uses XAML
- fully customizable
- 3rd party libraries

## Set up

1. Create a new project selecting `WPF Application - a project for creating a .NET WPF Application`
2. This will create a ready to use application with a window.
3. The `Toolbox` explorer will have ready made options for you.
4. The .xaml and .xaml.cs files work together. The .cs file is the 'Code behind' file. That gives the .xaml file its power
5. The .xaml file contains the UI components like buttons and grid.
6. Your main constructor the BUILD command for everything comes from `App.xaml.cs` and exports it as `App` class.
7. Create a `View` folder to container UI components - navbar, main
8. Add a `User Control WPF` c# item to create a components
9. The local name space in the new file XAML will be the link to call components and must be declaired in the main file
10. To use a `Windows Form` component right click and go to properties => enable windows forms
11. Creating new windows require you to link them to the main cs file from their View folder `using WPFTutorial.View;`
12. To quickly create a style sheet for a component press F4 to open 'properties'. Select the component on screen => miscilaniouse => style => convert to new resource => global style. 

## MVVM

Model View View Model

- Does use code behind but it is generally not needed an avoided.
- No business logic - uncoupling view from model
- Used for view specific logic



## Buttons

1. Name your button with `Name` or `Name.x` in xaml
2. You can now effect its properties using c# in the code behind by typing the name
3. set an onclick handler by using `Click="btn_Click"` in xaml
4. if you use the shortcuts for Click it will auto create an event handler in the c# file.

## Data Bindings

Connecting the UI and the underline data (codebehind) 


```cs
    Text="{Binding BoundText, UpdateSourceTrigger=PropertyChanged, Mode=OneWayToSource}"/>
```

## Grid

Grid comes by default for a WPF app
A responsive design grid.
Some properties will need to be defined as static if you dont want them to resize with the grid.
Its main controls are

- Grid.RowDefinitions
- Grid.ColumnDefinitions

These then contain a definition which create each sections

- RowDefinitions
- ColumnDefinitions

You then can tell components and elements which they belong to by using

- Grid.Rows="0"
- Grid.Column="1"

use `Width="*"` for responsive
use `Width="20*"` for responsive percentage

## StackPanel

- Aranges children horizontally or vetically (auto vertical)
- set to 'stretch' automatically
- Is static unlike grid

## GridSplitter

- Controls the grid and allows the user to resize windows
- reoccmened to use \* height rows

## XAML

A cross between HTML and CSS
Use Name property to connect to your c#

## Adding Style

1. Create a 'Styles' Folder
2. Create a new Item 'Resource Dictionairy'
3. Name it i.e 'ButtonStyles'
4. Add this code to your App.xaml file
5. To quickly create a style sheet for a component press F4 to open 'properties'. Select the component on screen => miscilaniouse => style => convert to new resource => global style. 

```cs
<Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Styles/ButtonStyles.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
```
### Style Examples

```cs
<Style TargetType="Button" x:Key="ConfirmationButton">
        <Setter Property="Width" Value="100" />
        <Setter Property="Height" Value="40" />
        <Setter Property="FontSize" Value="20" />
        <Setter Property="Foreground" Value="Red" />
        <Setter Property="Content" Value="OK" />
    </Style>

<Button Style="{StaticResource ConfirmationButton}"/>
```
## Functions

Using these in XAML will auto create a handler in cs

- Click
- TextChanged

### Examples

ADDING A COMPONENT
from a folder called user controls

```cs
 xmlns:userControls="clr-namespace:WPFTutorial.View.UserControls"

 <userControls:MenuBar />
```

TEXT BLOCK
These are the same way of writing a XAML component.

```cs
    <TextBlock Text="Hello World"/>

    <TextBlock>
        <TextBlock.Text>
            Hello World
        </TextBlock.Text>
    </TextBlock>
```

MENU
Drop down menu - buttons

```cs

<Menu>
    <MenuItem  Header="File" FontSize="16">
        <MenuItem Header="Exit"/>
    </MenuItem>

    <MenuItem  Header="Edit" FontSize="16"/>
</Menu>
```

GRID LAYOUT BASIC

```cs
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="70"/>
        <RowDefinition />
        <RowDefinition Height="20"/>
    </Grid.RowDefinitions>

    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="30"/>
            <RowDefinition Height="40"/>
        </Grid.RowDefinitions>

        <Menu>
            <MenuItem  Header="File" FontSize="16">
                <MenuItem Header="Exit"/>
            </MenuItem>

            <MenuItem  Header="Edit" FontSize="16"/>
        </Menu>

        <Grid Grid.Row="1">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="auto"/>
                <ColumnDefinition Width="auto"/>
            </Grid.ColumnDefinitions>
            <Button Width="50" Margin="5"/>
            <TextBox Width="150" Grid.Column="1" Margin="5"/>
        </Grid>

    </Grid>

</Grid>
```

VARIABLE STRINGS

// BASIC METHOD DO NOT USE
/// Use onpropertychange()

```cs
// Control text in
        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set {
                placeholder = value;
                tbPlaceholder.Text = placeholder;
            }
        }

// set item
<TextBlock x:Name="tbPlaceholder"
                   Text="{Binding Placeholder}"
                   FontSize="16"
                   FontWeight="Light"
                   Foreground="DarkGray"
                   VerticalAlignment="Center"
                   Margin="5,0,0,0"
                   Panel.ZIndex="-1"/>

// Set text
        <userControls:ClearableTextBox Grid.Row="1" Width="250" Height="40" Placeholder="First Name"/>

```

// USING INofityPropertyChanged

### Opening a new window

// The WPF window was added to a folder called View. The window is called NoramlWindow

```cs
using WPFTutorial.View;

private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            NormalWindow normalWindow = new NormalWindow();
            normalWindow.Show();
        }
```
