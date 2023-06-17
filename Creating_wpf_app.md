# Creating a WPF APP

1. Create a new WPF App

2. Add window chrome properties
   <WindowChrome.WindowChrome>
        <WindowChrome GlassFrameThickness="0" CornerRadius="0" CaptionHeight="0" />
    </WindowChrome.WindowChrome>
3. General properties
    WindowStyle="None"
    Background="#333333"
4. Create a top bar grid
   <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="40" />
            <RowDefinition />
        </Grid.RowDefinitions>
    </Grid>
5. 