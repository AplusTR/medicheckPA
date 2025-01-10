using Microsoft.Maui.Controls;
using ThyUcusArama.ViewModels;

namespace ThyUcusArama
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}