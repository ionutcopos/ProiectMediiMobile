using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using ProiectMediiMobile.Models;

namespace ProiectMediiMobile.Data
{
    public class SalonDatabase
    {
        readonly SQLite.SQLiteAsyncConnection _database;
        public SalonDatabase(string dbPath)
        {
            _database = new SQLite.SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ProiectMediiMobile.Models.Programare>().Wait();
            _database.CreateTableAsync<ProiectMediiMobile.Models.Stilist>().Wait();
            _database.CreateTableAsync<ProiectMediiMobile.Models.Salon>().Wait();
            _database.CreateTableAsync<ProiectMediiMobile.Models.Client>().Wait();
        }
        public Task<List<ProiectMediiMobile.Models.Salon>> GetSalonsAsync()
        {
            return _database.Table<ProiectMediiMobile.Models.Salon>().ToListAsync();
        }

        public Task<ProiectMediiMobile.Models.Salon> GetSalonAsync(int id)
        {
            return _database.Table<ProiectMediiMobile.Models.Salon>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveSalonAsync(ProiectMediiMobile.Models.Salon salon)
        {
            if (salon.ID != 0)
            {
                return _database.UpdateAsync(salon);
            }
            else
            {
                return _database.InsertAsync(salon);
            }
        }

        public Task<int> DeleteSalonAsync(ProiectMediiMobile.Models.Salon salon)
        {
            return _database.DeleteAsync(salon);
        }
        public async Task<List<ProiectMediiMobile.Models.Programare>> GetProgramariAsync()
        {
            var programari = await _database.Table<ProiectMediiMobile.Models.Programare>().ToListAsync();
            foreach (var programare in programari)
            {
                // Assuming SalonID and StilistID are foreign keys in your Programare model
                programare.Salon = await _database.Table<ProiectMediiMobile.Models.Salon>()
                    .Where(s => s.ID == programare.SalonID)
                    .FirstOrDefaultAsync();

                programare.Stilist = await _database.Table<ProiectMediiMobile.Models.Stilist>()
                    .Where(s => s.ID == programare.StilistID)
                    .FirstOrDefaultAsync();
            }
            return programari;
        }
        public Task<int> SaveProgramareAsync(ProiectMediiMobile.Models.Programare programare)
        {
            if (programare.ID != 0)
            {
                return _database.UpdateAsync(programare);
            }
            else
            {
                return _database.InsertAsync(programare);
            }
        }
        public Task<int> DeleteProgramareAsync(ProiectMediiMobile.Models.Programare programare)
        {
            return _database.DeleteAsync(programare);
        }
        public Task<List<ProiectMediiMobile.Models.Client>> GetClientsAsync()
        {
            return _database.Table<ProiectMediiMobile.Models.Client>().ToListAsync();
        }

        public Task<ProiectMediiMobile.Models.Client> GetClientAsync(int id)
        {
            return _database.Table<ProiectMediiMobile.Models.Client>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveClientAsync(ProiectMediiMobile.Models.Client client)
        {
            if (client.ID != 0)
            {
                return _database.UpdateAsync(client);
            }
            else
            {
                return _database.InsertAsync(client);
            }
        }

        public Task<int> DeleteClientAsync(ProiectMediiMobile.Models.Client client)
        {
            return _database.DeleteAsync(client);
        }
        public Task<List<ProiectMediiMobile.Models.Stilist>> GetStilistsAsync()
        {
            return _database.Table<ProiectMediiMobile.Models.Stilist>().ToListAsync();
        }

        public Task<ProiectMediiMobile.Models.Stilist> GetStilistAsync(int id)
        {
            return _database.Table<ProiectMediiMobile.Models.Stilist>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveStilistAsync(ProiectMediiMobile.Models.Stilist stilist)
        {
            if (stilist.ID != 0)
            {
                return _database.UpdateAsync(stilist);
            }
            else
            {
                return _database.InsertAsync(stilist);
            }
        }

        public Task<int> DeleteStilistAsync(ProiectMediiMobile.Models.Stilist stilist)
        {
            return _database.DeleteAsync(stilist);
        }
    }
}