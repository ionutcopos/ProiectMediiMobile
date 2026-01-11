
namespace ProiectMediiMobile.Pages.Client;

public partial class ClientEntryPage : ContentPage
{
    private ProiectMediiMobile.Models.Client currentClient;

    public ClientEntryPage()
    {
        InitializeComponent();
        currentClient = new ProiectMediiMobile.Models.Client();
    }

    public ClientEntryPage(ProiectMediiMobile.Models.Client client)
    {
        InitializeComponent();
        currentClient = client;
        LoadClientDetails();
    }

    private void LoadClientDetails()
    {
        numeEntry.Text = currentClient.Nume;
        emailEntry.Text = currentClient.Email;

    }

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        currentClient.Nume = numeEntry.Text;
        currentClient.Email = emailEntry.Text;

        await App.Database.SaveClientAsync(currentClient);
        await Navigation.PopAsync();
    }
}