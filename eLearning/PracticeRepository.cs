using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eLearning
{
    public class PracticeRepository
    {
        SQLiteAsyncConnection database;

        public PracticeRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<Practice>();
        }
        public async Task<List<Practice>> GetItemsAsync()
        {
            return await database.Table<Practice>().ToListAsync();
        }
        public async Task<Practice> GetItemAsync(int id)
        {
            return await database.GetAsync<Practice>(id);
        }
    }
}
