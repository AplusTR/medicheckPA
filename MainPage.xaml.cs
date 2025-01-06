using ObjCRuntime;
using static System.Net.Mime.MediaTypeNames;

using System.ComponentModel.DataAnnotations;

<? xml version = "1.0" encoding = "utf-8" ?>
< ContentPage xmlns = "http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns: x = "http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns: viewmodels = "clr-namespace:ThyUcusArama.ViewModels"
             x: Class = "ThyUcusArama.MainPage"
             x: DataType = "viewmodels:MainPageViewModel" >

    < ScrollView >
        < VerticalStackLayout
            Spacing = "25"
            Padding = "30,0"
            VerticalOptions = "Center" >

            < ListView ItemsSource = "{Binding Ports}" >
                < ListView.ItemTemplate >
                    < DataTemplate >
                        < ViewCell >
                            < StackLayout Orientation = "Horizontal" >
                                < Label Text = "{Binding Code}" />
                                < Label Text = "{Binding City.LanguageInfo.Language[0].Name}" />
                            </ StackLayout >
                        </ ViewCell >
                    </ DataTemplate >
                </ ListView.ItemTemplate >
            </ ListView >
        </ VerticalStackLayout >
    </ ScrollView >

</ ContentPage >