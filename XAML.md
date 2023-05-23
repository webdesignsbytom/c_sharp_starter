# XAML

## Table of contents

- [XAML](#xaml)
  - [Table of contents](#table-of-contents)
  - [Components](#components)
    - [Text Block](#text-block)
  - [Add images to Grid](#add-images-to-grid)
  - [Labels](#labels)
  - [Button](#button)
  - [Style](#style)

## Components

### Text Block

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
