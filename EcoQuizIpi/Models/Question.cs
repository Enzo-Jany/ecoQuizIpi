using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoQuizIpi.Models
{
    public class Question
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }

        public string GoodResponse { get; set; }

        public string WrongResponse { get; set; }
        
        //public Theme Theme { get; set; }

    }
}