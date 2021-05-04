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
	[Activity(Label = "Screen05")]
	public class Screen05 : Activity
	{
		public static Button btnOui;
		public static Button btnNon;
		public static TextView textView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			Xamarin.Essentials.Platform.Init(this, savedInstanceState);
			// Create your application here
			SetContentView(Resource.Layout.screen05);

			// UI Eleemnts
			//textView = FindViewById<TextView>(Resource.Id.textView1);
			btnOui = FindViewById<Button>(Resource.Id.btnOui);
			btnNon = FindViewById<Button>(Resource.Id.btnNon);
			btnOui.Click += delegate
			{
				Console.WriteLine("OUI OUI OUI");
				//textView.Text = "A bientôt ";

				Intent intent = new Intent(this, typeof(Screen03));
				StartActivity(intent);
			};
			btnNon.Click += delegate
			{
				Console.WriteLine("NON NON NON");
				//textView.Text = " Nous en sommes ravis ";

				Intent intent = new Intent(this, typeof(Screen03));
				StartActivity(intent);

			};


		}

	}
}