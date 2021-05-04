using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoQuizIpi.Activities
{
    [Activity(Label = "Screen03")]
    public class Screen03 : Activity
    {

        // Déclarer champ
        Button btnNewGame, btnInGame, btnTraining;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.screen03);

            btnNewGame = FindViewById<Button>(Resource.Id.btnNewGame);
            btnInGame = FindViewById<Button>(Resource.Id.btnInGame);
            btnTraining = FindViewById<Button>(Resource.Id.btnTraining);

        }

        protected override void OnResume()
        {
            base.OnResume();

            btnNewGame.Click += (sender, e) =>
            {
                Console.WriteLine("Click on new Game");
                
                Intent intent = new Intent(this, typeof(Screen04));
                StartActivity(intent);
                
            };

            btnInGame.Click += (sender, e) =>
            {
                Console.WriteLine("Click on game in progress");
                Intent intent = new Intent(this, typeof(Screen04));
                StartActivity(intent);
            };

            btnTraining.Click += (sender, e) =>
            {
                Console.WriteLine("Click on training");
                
                Intent intent = new Intent(this, typeof(Screen08));
                StartActivity(intent);
                
            };

        }
    }
}