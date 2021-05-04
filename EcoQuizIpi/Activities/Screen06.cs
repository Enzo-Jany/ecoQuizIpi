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
    [Activity(Label = "Screen06")]
    public class Screen06 : Activity
    {

        ImageButton btnRestart;
        ImageButton btnHome;
        TextView tvScore;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.screen06);



            //instancier les controles
            btnRestart = FindViewById<ImageButton>(Resource.Id.btnRestart);
            btnHome = FindViewById<ImageButton>(Resource.Id.btnHome);
            tvScore = FindViewById<TextView>(Resource.Id.tvScore);

            btnHome.Click += (sender, e) =>
            {
                //go home screen
                //Intent questionnaire = new Intent(this, typeof(home));
                //StartActivity(home);
            };

            btnRestart.Click += (sender, e) =>
            {
                //go restart screen
                //Intent questionnaire = new Intent(this, typeof(questionnaire));
                //StartActivity(questionnaire);
            };

            //On récupère le score je ne sais pas d'ou
            int question_number = 25;
            int score = 18;
            tvScore.Text = score + "/" + question_number;
        }

        /*        protected override void OnResume()
                {
                    base.OnResume();
                }*/
    }
}