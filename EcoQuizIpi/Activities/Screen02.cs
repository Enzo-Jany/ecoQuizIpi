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
    [Activity(Label = "Screen02")]
    public class Screen02 : Activity
    {

        Button btnStart;
        EditText editTextPseudo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.screen02);

            btnStart = FindViewById<Button>(Resource.Id.buttonStart);
            editTextPseudo = FindViewById<EditText>(Resource.Id.editTextPseudo);
        }

        protected override void OnResume()
        {
            base.OnResume();

            btnStart.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(Screen03));
                StartActivity(intent);
            };
        }
    }
}