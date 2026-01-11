namespace ProiectMediiMobile.Pages.Salon;

public partial class SalonListPage : ContentPage
{
    public SalonListPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadSalons();
    }

    private async void LoadSalons()
    {
        List<ProiectMediiMobile.Models.Salon> Salons = await App.Database.GetSalonsAsync();
        SalonListView.ItemsSource = Salons;
    }

    private async void OnAddSalonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SalonEntryPage());
    }

    private async void OnSalonSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is ProiectMediiMobile.Models.Salon selectedSalon)
        {
            await Navigation.PushAsync(new SalonDetailPage(selectedSalon));
            SalonListView.SelectedItem = null;
        }
    }
}