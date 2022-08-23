using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace eLearning
{
    public class UserRepository
    {
        SQLiteAsyncConnection database;
      
        public UserRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<User>();
        }
        public async Task<List<User>> GetItemsAsync()
        {
            return await database.Table<User>().ToListAsync();

        }
        public async Task<User> GetItemAsync(int id)
        {
            return await database.GetAsync<User>(id);//получить профиль через LINQ
        }
        public async Task<int> DeleteItemAsync(User item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(User item)
        {
            if (item.ID != 0)
            {
                await database.UpdateAsync(item);
                return item.ID;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
    }
}
