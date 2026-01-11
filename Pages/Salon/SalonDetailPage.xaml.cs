using ProiectMediiMobile.Models;
namespace ProiectMediiMobile.Pages.Salon;

public partial class SalonDetailPage : ContentPage
{
    private ProiectMediiMobile.Models.Salon currentSalon;
    
    
    public SalonDetailPage(ProiectMediiMobile.Models.Salon salon)
    {
        InitializeComponent();
        currentSalon = salon;
        BindingContext = currentSalon;
    }

    private async void OnEditButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SalonEntryPage(currentSalon));
    }

    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        bool isUserConfirmed = await DisplayAlert("Sterge Salon", "Esti sigur ca vrei sa stergi acest Salon?", "Da", "Nu");

        if (isUserConfirmed)
        {
            await App.Database.DeleteSalonAsync(currentSalon);
            await Navigation.PopAsync();
        }
    }
}