using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class MainViewModel : ObservableObject
    {
        public string Title => "Hello, Maui!";

        public ObservableCollection<string> Items { get; set; } = ["Item 1", "Item 2", "Item 3"];

        /// <summary>
        /// item is always null. This was not the case in https://github.com/Axemasta/Maui.TouchEffect
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [RelayCommand]
        private Task ShowItem(string item) => Application.Current.MainPage.DisplayAlert($"Selected value:", item, "OK");
    }
}