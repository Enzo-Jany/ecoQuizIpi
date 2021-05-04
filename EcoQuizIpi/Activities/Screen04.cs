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
    [Activity(Label = "Screen04")]
    public class Screen04 : Activity
    {
        private ImageButton BackBtn { get; set; }
        private ImageView ThemeImg { get; set; }
        private TextView ThemeTxt { get; set; }
        private TextView QuestionTxt { get; set; }
        private Button FirstAnswerBtn { get; set; }
        private Button SecondAnswerBtn { get; set; }

        private String SelectedTheme { get; set; }
        private String SelectedQuestion { get; set; }
        private String TrueAnswer { get; set; }
        private String FalseAnswer { get; set; }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.screen04);


        }

        protected override void OnResume()
        {
            base.OnResume();
            InitComponents();
            
        }

        private void InitComponents()
        {
            SelectedTheme = "Environnement";
            // Init default values before getting final values
            SelectedQuestion = "Est-ce que la terre est ronde?";
            TrueAnswer = "Je suis la réalité..";
            FalseAnswer = "Je ne suis là que pour t'embrouiller!";

            BackBtn = FindViewById<ImageButton>(Resource.Id.backImgBtn);
            ThemeImg = FindViewById<ImageView>(Resource.Id.themeImg);
            ThemeTxt = FindViewById<TextView>(Resource.Id.themeTxt);
            QuestionTxt = FindViewById<TextView>(Resource.Id.questionTxt);
            FirstAnswerBtn = FindViewById<Button>(Resource.Id.firstAnswerBtn);
            SecondAnswerBtn = FindViewById<Button>(Resource.Id.secondAnswerBtn);

            BackBtn.SetImageResource(Resource.Drawable.arrow_left);
            BackBtn.Click += OnBackBtnClick;
            InitThemeChoice();
            ThemeTxt.Text = SelectedTheme;
            QuestionTxt.Text = SelectedQuestion;
            string[] shuffledAnswers = ShuffleAnswers();
            FirstAnswerBtn.Text = shuffledAnswers[0];
            FirstAnswerBtn.Click += OnChoiceBtnClick;
            SecondAnswerBtn.Text = shuffledAnswers[1];
            SecondAnswerBtn.Click += OnChoiceBtnClick;
        }

        private void InitThemeChoice()
        {
            switch (SelectedTheme)
            {
                case "Environnement":
                    ThemeImg.SetImageResource(Resource.Drawable.coccinelle);
                    break;
                case "Air":
                    ThemeImg.SetImageResource(Resource.Drawable.eoliennes);
                    break;
                case "Eau":
                    ThemeImg.SetImageResource(Resource.Drawable.goutte_eau);
                    break;
                case "Déchet":
                    ThemeImg.SetImageResource(Resource.Drawable.poubelle);
                    break;
                default:
                    ThemeImg.SetImageResource(Resource.Drawable.coccinelle);
                    break;
            }
        }

        private string[] ShuffleAnswers()
        {
            Random rnd = new Random();
            string[] sortedAnswers = new string[] { TrueAnswer, FalseAnswer };
            return sortedAnswers.OrderBy(x => rnd.Next()).ToArray();
        }

        void OnBackBtnClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Screen05));
            StartActivity(intent);
        }

        void OnChoiceBtnClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Screen06));
            StartActivity(intent);
        }
    }
}