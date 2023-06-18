# Styles

Styles are importable for seperate files using the ResourceDictionairy componets
For examples see style.xaml

## Setting styles

```js 
<Style x:Key="HeaderStyle"
    TargetType="TextBlock">

    <Setter Property="FontFamily"
        Value="Fonts/Cairo-SemiBold.ttf #Cairo SemiBold" />
    <Setter Property="FontSize"
        Value="24" />
>
```

## ResourceDictionairy

Connect a RD to the main file or app.xaml in the main secion

```js
<ResourceDictionary>
  <ResourceDictionary.MergedDictionaries>
    <ResourceDictionary Source='Styles.xaml' />
  </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```
