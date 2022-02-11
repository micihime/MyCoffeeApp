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
            BindingContext = this; //subscribe to events on this object - whenever OnPropertyCHanged occurs, automatically update it
        }


        int count = 0;
        string countDisplay = "Click me.";

        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay)
                    return;

                countDisplay = value;
                OnPropertyChanged(); //could be also OnPropertyChanged("CountDisplay"); or OnPropertyChanged(nameof(CountDisplay));
            }
        }

        private void ButtonCLick_Clicked(object sender, EventArgs e)
        {
            count++;
            CountDisplay = $"You clicked {count} time(s).";
        }
    }
}