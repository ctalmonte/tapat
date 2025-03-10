using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Tapat
{
    [Activity(Label = "Fingerprint_Voter")]
    public class Fingerprint_Voter : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Fingerprint_Voter);

            ImageButton fp = FindViewById<ImageButton>(Resource.Id.img_fp);

            fp.Click += delegate {
                StartActivity(typeof(Tapat.MainMenu));
            };
        }
    }
}