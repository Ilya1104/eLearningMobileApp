using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace eLearning
{
   public class LessonRepository
    {
        SQLiteAsyncConnection database;

        public LessonRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<Lesson>();
        }
        public async Task<List<Lesson>> GetItemsAsync()
        {
            return await database.Table<Lesson>().ToListAsync();
        }
        public async Task<Lesson> GetItemAsync(int id)
        {
            return await database.GetAsync<Lesson>(id);
        }
      

    }
}
