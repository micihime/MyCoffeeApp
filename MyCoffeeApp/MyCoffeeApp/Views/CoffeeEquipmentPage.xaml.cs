using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCoffeeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {
        public CoffeeEquipmentPage()
        {
            InitializeComponent();
            LabelCount.Text = "Hello from Code Behind!";
        }


        int count = 0;

        private void ButtonCLick_Clicked(object sender, EventArgs e)
        {
            count++;
            LabelCount.Text = $"You clicked {count} time(s).";
        }
    }
}