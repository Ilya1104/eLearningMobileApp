using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eLearning
{
    public class TestRepository
    {
        SQLiteAsyncConnection database;

        public TestRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<Test>();
        }
        public async Task<List<Test>> GetItemsAsync()
        {
            return await database.Table<Test>().ToListAsync();
        }
        public async Task<Test> GetItemAsync(int id)
        {
            return await database.GetAsync<Test>(id);
        }
    }
}
