using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using System;

namespace EcoQuizIpi.Activities
{
    [Activity(Label = "Screen09")]
    public class Screen09 : Activity
    {
        public Button btnNiv1;
        public Button btnNiv2;
        public Button btnNiv3;
        public Button btnNiv4;
        public Button btnNiv5;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.screen09);
            btnNiv2 = FindViewById<Button>(Resource.Id.btnNiv1);
            /*btnNiv3 = FindViewById<Button>(Resource.Id.btnni);
            btnNiv4 = FindViewById<Button>(Resource.Id.btnNiv4);
            btnNiv5 = FindViewById<Button>(Resource.Id.btnNiv5);*/
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnResume()
        {
            base.OnResume();

            //this.btnNiv1.Click += (sender, e) =>
            //{
            //    Console.WriteLine("click");
            //};
            //this.btnNiv2.Click += (sender, e) =>
            //{
            //    Console.WriteLine("click");
            //};
            //this.btnNiv3.Click += (sender, e) =>
            //{
            //    Console.WriteLine("click");
            //};
            //this.btnNiv4.Click += (sender, e) =>
            //{
            //    Console.WriteLine("click");
            //};
            //this.btnNiv5.Click += (sender, e) =>
            //{
            //    Console.WriteLine("click");
            //};
        }
    }
}