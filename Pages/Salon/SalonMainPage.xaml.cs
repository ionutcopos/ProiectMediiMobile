namespace ProiectMediiMobile.Pages.Salon
{
    public partial class SalonMainPage : ContentPage
    {
        public SalonMainPage()
        {
            InitializeComponent();
        }

        private async void OnViewClientsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProiectMediiMobile.Pages.Client.ClientListPage());
        }

        private async void OnViewSalonsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SalonListPage());
        }

        private async void OnViewProgramariClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProiectMediiMobile.Pages.Programare.ProgramareListPage());
        }
    }
}