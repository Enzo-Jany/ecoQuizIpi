using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using EcoQuizIpi.Activities;
using EcoQuizIpi.Data;
using EcoQuizIpi.Models;
using SQLite;
using System.IO;

namespace EcoQuizIpi
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, ScreenOrientation =Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : AppCompatActivity
    {

        static EcoQuizDatabase db;

        public static EcoQuizDatabase SQLiteDb
        {
            get
            {
                if (db == null)
                {
                    string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                    db = new EcoQuizDatabase(Path.Combine(folder, "EcoQuizDatabase.db"));
                }
                return db;
            }
        }

       


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //System.Console.WriteLine(Path.Combine(System.Environment.SpecialFolder.LocalApplicationData.ToString(), "Notes.db3"));
            System.Console.WriteLine("###### DATABASE CREATION");
           

        }

        protected async override void OnResume()
        {
            base.OnResume();
            System.Console.WriteLine(" #### OnResume !!!!");

            //SQLiteDb.GetPlayerAsync();

            var playerList = await SQLiteDb.GetPlayersAsync();
            if (playerList.Count==0)
            {
                System.Console.WriteLine(" PAS DE JOUEUR !!!!");
            }

            Player player = new Player();
            player.ID = 0;
            player.Name = "Bruno";
            player.Score = 0;
            player.Date = new System.DateTime();

            await SQLiteDb.SavePlayerAsync(player);

            playerList = await SQLiteDb.GetPlayersAsync();
            if (playerList.Count > 0)
            {
                System.Console.WriteLine(" ya des joueurs !!!!");
            }

            Intent intent = new Intent(this, typeof(Screen01));
            StartActivity(intent);

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}