﻿using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Windows.Input;

namespace MyCoffeeApp.ViewModels
{
    public class CoffeeEquipmentViewModel : BaseViewModel
    {
        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            Title = "Coffee Equipment";
        }

        public ICommand IncreaseCount { get; }

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
    }
}
