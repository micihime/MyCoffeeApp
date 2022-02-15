using MvvmHelpers;
using MvvmHelpers.Commands;
using MyCoffeeApp.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyCoffeeApp.ViewModels
{
    public class CoffeeEquipmentViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Coffee> Coffee { get; set; } //everytime item is added/removed/... xamarin.forms will get a notification, but you cannot add range - for every item added/removed/... there will be a notification and an update - 100 changes means 100 notifications and updates
        public ObservableRangeCollection<Grouping<string, Coffee>> CoffeeGroups { get; set; }

        public ICommand RefreshCommand { get; }

        public CoffeeEquipmentViewModel()
        {
            Title = "Coffee Equipment";

            Coffee = new ObservableRangeCollection<Coffee>();
            CoffeeGroups = new ObservableRangeCollection<Grouping<string, Coffee>>();

            var image = "https://upload.wikimedia.org/wikipedia/commons/c/c5/Roasted_coffee_beans.jpg";
            Coffee.Add(new Coffee { Roaster = "R1", Name = "C1", Image = image });
            Coffee.Add(new Coffee { Roaster = "R2", Name = "C2", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });
            Coffee.Add(new Coffee { Roaster = "R3", Name = "C3", Image = image });

            CoffeeGroups.Add(new Grouping<string, Coffee>("G1", Coffee.Take(2).ToList()));
            CoffeeGroups.Add(new Grouping<string, Coffee>("G2", Coffee.Skip(2).Take(10).ToList()));

            RefreshCommand = new AsyncCommand(Refresh); //without MVVM Helpers we would need to call it like: CallServerCommand = new Command(async => await CallServer()); - hack, not elegant, can swallow exceptions
        }

        async Task Refresh()
        {
            IsBusy = true;
            await Task.Delay(2000);
            IsBusy = false;
        }
    }
}
