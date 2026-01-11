namespace ProiectMediiMobile.Pages.Stilist;

public partial class StilistDetailPage : ContentPage
{
    private ProiectMediiMobile.Models.Stilist currentStilist;

    public StilistDetailPage(ProiectMediiMobile.Models.Stilist Stilist)
    {
        InitializeComponent();
        currentStilist = Stilist;
        BindingContext = currentStilist;
    }

    private async void OnEditButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StilistEntryPage(currentStilist));
    }

    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        bool isUserConfirmed = await DisplayAlert("Sterge Stilist", "Esti sigur ca vrei sa stergi acest Stilist?", "Da", "Nu");

        if (isUserConfirmed)
        {
            await App.Database.DeleteStilistAsync(currentStilist);
            await Navigation.PopAsync();
        }
    }
}