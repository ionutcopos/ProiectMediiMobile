namespace ProiectMediiMobile.Pages.Stilist
{
    public partial class StilistEntryPage : ContentPage
    {
        private ProiectMediiMobile.Models.Stilist currentStilist;

        public StilistEntryPage()
        {
            InitializeComponent();
            currentStilist = new ProiectMediiMobile.Models.Stilist();
        }

        public StilistEntryPage(ProiectMediiMobile.Models.Stilist Stilist)
        {
            InitializeComponent();
            currentStilist = Stilist;
            LoadStilistDetails();
        }

        private void LoadStilistDetails()
        {
            numeEntry.Text = currentStilist.Nume;
            pretEntry.Text = currentStilist.Pret.ToString();
            salonIdEntry.Text = currentStilist.SalonID?.ToString();
        }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            currentStilist.Nume = numeEntry.Text;

            if (decimal.TryParse(pretEntry.Text, out decimal pret))
            {
                currentStilist.Pret = pret;
            }
            else
            {
                await DisplayAlert("Invalid Input", "Please enter a valid price.", "OK");
                return;
            }

            if (int.TryParse(salonIdEntry.Text, out int salonId))
            {
                currentStilist.SalonID = salonId;
            }
            else
            {
                await DisplayAlert("Invalid Input", "Please enter a valid Salon ID.", "OK");
                return;
            }

            await App.Database.SaveStilistAsync(currentStilist);
            await Navigation.PopAsync();
        }
    }
}
