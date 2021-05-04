using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace EcoQuizIpi.Activities
{
    [Activity(Label = "Screen10")]
    public class Screen10 : Activity
    {
        private TextView tvName1;
        private TextView tvName2;
        private TextView tvName3;
        private TextView tvName4;

        private TextView tvScore1;
        private TextView tvScore2;
        private TextView tvScore3;
        private TextView tvScore4;
    

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.screen10);

            tvName1 = FindViewById<TextView>(Resource.Id.tvName1);
            tvName2 = FindViewById<TextView>(Resource.Id.tvName2);
            tvName3 = FindViewById<TextView>(Resource.Id.tvName3);
            tvName4 = FindViewById<TextView>(Resource.Id.tvName4);

            tvScore1 = FindViewById<TextView>(Resource.Id.tvScore1);
            tvScore2 = FindViewById<TextView>(Resource.Id.tvScore2);
            tvScore3 = FindViewById<TextView>(Resource.Id.tvScore3);
            tvScore4 = FindViewById<TextView>(Resource.Id.tvScore4);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}