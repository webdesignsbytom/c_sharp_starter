# XAML

## Table of contents

- [XAML](#xaml)
  - [Table of contents](#table-of-contents)
    - [Component list](#component-list)
    - [Attributes](#attributes)
    - [Function List](#function-list)
    - [C# functions](#c-functions)
  - [Components](#components)
    - [Text Block](#text-block)
  - [Add images to Grid](#add-images-to-grid)
  - [Labels](#labels)
  - [Button](#button)
  - [Style](#style)
  - [WindowChrome](#windowchrome)

### Component list

- The window! props = WindowStyle, none = blank slate.
- Grid
  - Grid RowDefinition
  - Grid ColumnDefinition
- StackPanel - secondary elements in a single line
- DockPanel - left right up or down
- WrapPanel - right to left or top to bottom - auto reareange
- Canvas - coordiantes
- Border - add border effects and roudned
- ControlTemplate
- Style
  - Style.Resources
- Setter
- DataTrigger
  - Trigger
- Expander - down arrow to open menu props = Header, border(default white), expandDirection (arrow points)
- ListView
- ScrollViewer - how to add a scroll bar - props = VerticalScrollBarVisibility(auto = when needed), horizonotal default hidden, hidden = invisible.
- Button
- TextBox
- TextBlock
- Rectangle

### Attributes

- CornerRadius
- Background
- Foreground
- Content = usually button display data
- IsEnabled = set button to unclickable
- TextChanged = detecting changes - creates a handler

### Function List

- Click - onclick function
- MouseLeftButtonDown - used for dragging using c# `DragMove();`

### C# functions

- `ShowDialog()` - opens a modal
- `DragMove();` - drag the window around - normally connected to a on mouse down event

## Components

WINDOW

- `WindowStartupLocation="CenterOwner"` start in middle of window that started it

### Text Block

Window.Resources - Add style pages to xaml
Set each property with a value

```cs
<Window.Resources>
        <Style TargetType="TextBox">
            <Setter Property="Width" Value="200" />
            <Setter Property="Height" Value="40" />
            <Setter Property="FontSize" Value="20" />
            <Setter Property="FontWeight" Value="Light" />
        </Style>
    </Window.Resources>
```

```cs
<Grid>
    <TextBlock HorizontalAlignment="Left" Margin="387,60,0,0" TextWrapping="Wrap" Text="Select a message option and then choose the Display button." VerticalAlignment="Top"/>
</Grid>

// RadioButton example
<Grid>
     <TextBlock HorizontalAlignment="Left" Margin="252,47,0,0" TextWrapping="Wrap" Text="Select a message option and then choose the Display button." VerticalAlignment="Top"/>
     <RadioButton x:Name="HelloButton" Content="Hello" HorizontalAlignment="Left" Margin="297,161,0,0" VerticalAlignment="Top"/>
     <RadioButton x:Name="GoodbyeButton" Content="Goodbye" HorizontalAlignment="Left" Margin="488,161,0,0" VerticalAlignment="Top"/>
</Grid>

// button
<Grid>
     <TextBlock HorizontalAlignment="Left" Margin="252,47,0,0" TextWrapping="Wrap" Text="Select a message option and then choose the Display button." VerticalAlignment="Top"/>
     <RadioButton x:Name="HelloButton" Content="Hello" IsChecked="True" HorizontalAlignment="Left" Margin="297,161,0,0" VerticalAlignment="Top"/>
     <RadioButton x:Name="GoodbyeButton" Content="Goodbye" HorizontalAlignment="Left" Margin="488,161,0,0" VerticalAlignment="Top"/>
     <Button Content="Display" HorizontalAlignment="Left" Margin="377,270,0,0" VerticalAlignment="Top" Width="75"/>
</Grid>
```

When this application runs, a message box appears after a user chooses a radio button and then chooses the Display button. One message box will appear for Hello, and another will appear for Goodbye. To create this behavior, you'll add code to the Button_Click
event in MainWindow.xaml.cs.
On the design surface, double-click the Display button.

MainWindow.xaml.cs opens, with the cursor in the Button_Click event.
C# file

```cs
private void Button_Click(object sender, RoutedEventArgs e)
{
}
////Enter the following code:
//C#
if (HelloButton.IsChecked == true)
{
     MessageBox.Show("Hello.");
}
else if (GoodbyeButton.IsChecked == true)
{
    MessageBox.Show("Goodbye.");
}
```

## Add images to Grid

```cs
<Grid.Background>
    <ImageBrush ImageSource="watermark.png"/>
</Grid.Background>
```

## Labels

```cs
<Label Grid.Column="1" VerticalAlignment="Center" FontFamily="Trebuchet MS"
        FontWeight="Bold" FontSize="18" Foreground="#0066cc">
    View Expense Report
</Label>
```

## Button

```cs
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            ExpenseReportPage expenseReportPage = new ExpenseReportPage();
            this.NavigationService.Navigate(expenseReportPage);
        }
```

## Style

https://learn.microsoft.com/en-us/dotnet/desktop/wpf/controls/control-styles-and-templates?view=netframeworkdesktop-4.8

in app.xaml

```cs
        <!-- Header text style -->
        <Style x:Key="headerTextStyle">
            <Setter Property="Label.VerticalAlignment" Value="Center"></Setter>
            <Setter Property="Label.FontFamily" Value="Trebuchet MS"></Setter>
            <Setter Property="Label.FontWeight" Value="Bold"></Setter>
            <Setter Property="Label.FontSize" Value="18"></Setter>
            <Setter Property="Label.Foreground" Value="#0066cc"></Setter>
        </Style>
```

## WindowChrome

This is to do with controlling the premade borders any app will have. To reduce it to none use the following code before grid but outside window.

```cs
    <WindowChrome.WindowChrome>
        <WindowChrome GlassFrameThickness="0" CornerRadius="0" CaptionHeight="0" />
    </WindowChrome.WindowChrome>
```
