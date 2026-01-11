using ProiectMediiMobile.Data;
using System.IO;
using Microsoft.Maui.Controls; 

namespace ProiectMediiMobile
{
    public partial class App : Application
    {
        static SalonDatabase database;

        // Static property to access the database
        public static SalonDatabase Database
        {
            get
            {
                if (database == null)
                {
                    // Define the path for the database file
                    string dbPath = Path.Combine(FileSystem.AppDataDirectory, "SalonDB.db3");
                    database = new SalonDatabase(dbPath);
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
