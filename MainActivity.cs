using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;

namespace CheckBox_Xamarin_Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        CheckBox chkBanana_Obj;
        CheckBox chkOrange_Obj;
        CheckBox chkApple_Obj;
        Button btnSelection_Obj;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // Get our button from the layout resource,
            // and attach an event to it

            btnSelection_Obj = FindViewById<Button>(Resource.Id.btnSelection);
            chkBanana_Obj = FindViewById<CheckBox>(Resource.Id.chkBanana);
            chkApple_Obj = FindViewById<CheckBox>(Resource.Id.chkApple);
            chkOrange_Obj = FindViewById<CheckBox>(Resource.Id.chkOrange);

            btnSelection_Obj.Click += OnSelection_ObjClick;

            chkBanana_Obj.Click += ChkBanana_Obj_Click;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        private void ChkBanana_Obj_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Banana Checked", ToastLength.Short).Show();
        }

        public void OnSelection_ObjClick(object sender, EventArgs e)
        {
            if (chkBanana_Obj.Checked)
            {
                Toast.MakeText(this, "Banana Checked", ToastLength.Short).Show();
            }
            if (chkOrange_Obj.Checked)
            {
                Toast.MakeText(this, "Orange Checked", ToastLength.Short).Show();
            }
            if (chkApple_Obj.Checked)
            {
                Toast.MakeText(this, "Apple Checked", ToastLength.Short).Show();
            }
        }
    }
}