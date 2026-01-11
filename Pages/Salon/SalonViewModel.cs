using CommunityToolkit.Mvvm.Input;  // ← add this nuget if not present: CommunityToolkit.Mvvm

namespace ProiectMediiMobile.Pages.Salon
{
    public partial class SalonViewModel
    {
        [RelayCommand]
        private async Task Clients()
        {
            // Your logic here
            await Application.Current.MainPage.DisplayAlert("Clients", "Clicked via Command!", "OK");
        }

        // or if you need parameter:
        // [RelayCommand]
        // private async Task Clients(object parameter) { ... }
    }
}