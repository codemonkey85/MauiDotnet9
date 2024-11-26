using MauiDotnet9.Models;
using MauiDotnet9.PageModels;

namespace MauiDotnet9.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}