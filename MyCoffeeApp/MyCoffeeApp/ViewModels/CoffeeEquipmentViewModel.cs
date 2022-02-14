using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyCoffeeApp.ViewModels
{
    public class CoffeeEquipmentViewModel : ViewModelBase
    {
        public ObservableRangeCollection<string> Coffee { get; } //everytime item is added/removed/... xamarin.forms will get a notification, but you cannot add range - for every item added/removed/... there will be a notification and an update - 100 changes means 100 notifications and updates

        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            CallServerCommand = new AsyncCommand(CallServer); //without MVVM Helpers we would need to call it like: CallServerCommand = new Command(async => await CallServer()); - hack, not elegant, can swallow exceptions
            Coffee = new ObservableRangeCollection<string>();

            Title = "Coffee Equipment";
        }

        public ICommand IncreaseCount { get; }
        public ICommand CallServerCommand { get; }

        int count = 0;
        string countDisplay = "Click me.";

        public string CountDisplay
        {
            get => countDisplay;
            set => SetProperty(ref countDisplay, value);
        }

        void OnIncrease()
        {
            count++;
            CountDisplay = $"You clicked {count} time(s).";
        }

        async Task CallServer()
        {
            var items = new List<string> { "Yes Plz", "Tonx", "Blue Bottle" };
            Coffee.AddRange(items);
        }
    }
}
