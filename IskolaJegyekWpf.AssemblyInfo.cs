<Window x:Class="IskolaJegyekWpf.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:viewModels="clr-namespace:IskolaJegyekWpf.ViewModels"
        mc:Ignorable="d"
        Title="Iskolai jegyek" Height="400" Width="800">



    <Grid Margin="10">
        <DataGrid ItemsSource="{Binding Jegyek}"
                  AutoGenerateColumns="False"
                  IsReadOnly="True">
            
        </DataGrid>
    </Grid>
</Window>
