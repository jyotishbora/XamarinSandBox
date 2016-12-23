using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;
using XamarinSandBox.Core.ViewModels;

namespace XamarinSandBox.Droid.Activity
{
    [Activity(
       Label = "Examples",
       Theme = "@style/AppTheme.Login",
       LaunchMode = LaunchMode.SingleTop,
       ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize,
       Name = "xamarinsandbox.droid.activities.LoginActivity"
   )]
    public class LoginActivity:MvxAppCompatActivity<LoginViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.login_activity);
        }
    }
}