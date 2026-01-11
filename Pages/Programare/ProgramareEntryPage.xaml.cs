using ProiectMediiMobile.Models; // Import your models namespace
using System;

namespace ProiectMediiMobile.Pages.Programare
{
    public partial class ProgramareEntryPage : ContentPage
    {
        public ProgramareEntryPage()
        {
            InitializeComponent();
            LoadSalonsAndStilists();
        }
        

        public ProgramareEntryPage(ProiectMediiMobile.Models.Programare programare)
        {
            InitializeComponent();
            LoadSalonsAndStilists();
        }

        private async void LoadSalonsAndStilists()
        {
            // Fetch salons and stilists from the database
            var salons = await App.Database.GetSalonsAsync();
            var stilists = await App.Database.GetStilistsAsync();

            // Populate the picker items
            salonPicker.ItemsSource = salons;
            stilistPicker.ItemsSource = stilists;
        }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Create a new Programare object
            var newProgramare = new ProiectMediiMobile.Models.Programare 
            {
                
                DataProgramarii = dataDatePicker.Date,
                Salon = salonPicker.SelectedItem as ProiectMediiMobile.Models.Salon, // Cast selected item to Salon
                Stilist = stilistPicker.SelectedItem as ProiectMediiMobile.Models.Stilist, // Cast selected item to Stilist
            };

            // Save the new Programare to the database
            await App.Database.SaveProgramareAsync(newProgramare);

            // Navigate back to the previous page
            await Navigation.PopAsync();
        }
    }
}
