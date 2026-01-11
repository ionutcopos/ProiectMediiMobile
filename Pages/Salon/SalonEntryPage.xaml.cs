
namespace ProiectMediiMobile.Pages.Salon;

public partial class SalonEntryPage : ContentPage
{
    private ProiectMediiMobile.Models.Salon currentSalon;

    public SalonEntryPage()
    {
        InitializeComponent();
        currentSalon = new ProiectMediiMobile.Models.Salon();
    }

    public SalonEntryPage(ProiectMediiMobile.Models.Salon Salon)
    {
        InitializeComponent();
        currentSalon = Salon;
        LoadSalonDetails();
    }

    private void LoadSalonDetails()
    {
        numeEntry.Text = currentSalon.Nume;
        orasEntry.Text = currentSalon.Oras;
        pretEntry.Text = currentSalon.Pret;
        categorieEntry.Text = currentSalon.Categorie;



    }

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        currentSalon.Nume = numeEntry.Text;
        currentSalon.Oras = orasEntry.Text;
        currentSalon.Pret = pretEntry.Text;
        currentSalon.Categorie = categorieEntry.Text;


        await App.Database.SaveSalonAsync(currentSalon);
        await Navigation.PopAsync();
    }
}