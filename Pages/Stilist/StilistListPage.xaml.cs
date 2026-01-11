namespace ProiectMediiMobile.Pages.Stilist
{
    public partial class StilistListPage : ContentPage
    {
        public StilistListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadStilists();
        }

        private async void LoadStilists()
        {
            var stilists = await App.Database.GetStilistsAsync();
            StilistCollectionView.ItemsSource = stilists; // Update to use CollectionView
        }

        private async void OnAddStilistClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StilistEntryPage());
        }

        private async void OnStilistSelected(object sender, SelectionChangedEventArgs e)
        {
            var selectedStilist = e.CurrentSelection.FirstOrDefault() as ProiectMediiMobile.Models.Stilist;
            if (selectedStilist != null)
            {
                await Navigation.PushAsync(new StilistDetailPage(selectedStilist));
                // Clear selection
                StilistCollectionView.SelectedItem = null;
            }
        }
    }
}
