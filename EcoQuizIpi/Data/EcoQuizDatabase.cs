using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EcoQuizIpi.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoQuizIpi.Data
{
    public class EcoQuizDatabase
    {
        readonly SQLiteAsyncConnection database;

        public EcoQuizDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Player>().Wait();
            database.CreateTableAsync<Theme>().Wait();
            database.CreateTableAsync<Question>().Wait();
        }

        public Task<List<Player>> GetPlayersAsync()
        {
            //Get all players.
            return database.Table<Player>().ToListAsync();
        }

        public Task<Player> GetPlayerAsync(int id)
        {
            // Get a specific player.
            return database.Table<Player>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SavePlayerAsync(Player player)
        {
            if (player.ID != 0)
            {
                // Update an existing player.
                return database.UpdateAsync(player);
            }
            else
            {
                // Save a new player.
                return database.InsertAsync(player);
            }
        }

        public Task<int> DeletePlayerAsync(Player player)
        {
            // Delete a player.
            return database.DeleteAsync(player);
        }


        //THEMES

        public Task<List<Theme>> GetThemesAsync()
        {
            //Get all players.
            return database.Table<Theme>().ToListAsync();
        }

        public Task<Theme> GetThemeAsync(int id)
        {
            // Get a specific player.
            return database.Table<Theme>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        //THEMES

        public Task<List<Question>> GetQuestionsAsync()
        {
            //Get all players.
            return database.Table<Question>().ToListAsync();
        }

        public Task<Question> GetQuestionAsync(int id)
        {
            // Get a specific player.
            return database.Table<Question>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }
    }
}