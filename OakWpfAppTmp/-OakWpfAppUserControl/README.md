## User Control

![](pictures/OakWpfAppUserControl.PNG)

```xml
<Window x:Class="OakWpfAppUserControl.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:OakWpfAppUserControl"
        xmlns:viewmodels="clr-namespace:OakWpfAppUserControl.ViewModels"
        xmlns:views="clr-namespace:OakWpfAppUserControl.Views"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="4*"/>
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
            <RowDefinition Height="*" />
            <RowDefinition Height="*" />
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>
        <Canvas Grid.Column="1" Grid.RowSpan="4">
            <ContentControl  Content="{Binding}"/>
        </Canvas>
        <Button x:Name="btnTextBox" Content="TextBox" Height="NaN" Width="NaN" FontSize="20" Click="btnTextBox_Click"/>
        <Button x:Name="btnComboBox" Content="ComboBox" Grid.Row="1" Height="NaN" Width="NaN" FontSize="20" Click="btnComboBox_Click"/>
        <Button x:Name="btnDataPicker" Content="DataPicker" Grid.Row="2" Height="NaN" Width="NaN" FontSize="20" Click="btnDataPicker_Click"/>
        <Button x:Name="btnLabel" Content="Label" Grid.Row="3" Height="NaN" Width="NaN" FontSize="20" Click="btnLabel_Click"/>
    </Grid>
    <Window.Resources>
        <DataTemplate x:Name="texttemplate" DataType="{x:Type viewmodels:TextViewModel}">
            <views:TextViewControl>

            </views:TextViewControl>
        </DataTemplate>
        <DataTemplate x:Name="combotemplate" DataType="{x:Type viewmodels:ComboViewModel}">
            <views:ComboViewControl>

            </views:ComboViewControl>
        </DataTemplate>
        <DataTemplate x:Name="datapickertemplate" DataType="{x:Type viewmodels:DatePickerViewModel}">
            <views:DatePickerViewControl>

            </views:DatePickerViewControl>
        </DataTemplate>
        <DataTemplate x:Name="labeltemplate" DataType="{x:Type viewmodels:LabelViewModel}">
            <views:LabelViewControl>

            </views:LabelViewControl>
        </DataTemplate>
    </Window.Resources>
</Window>
```