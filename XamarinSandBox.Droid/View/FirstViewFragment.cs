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
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views;
using XamarinSandBox.Core.ViewModels;
using MvvmCross.Droid.Shared.Attributes;
using XamarinSandBox.Droid.Activity;
using Toolbar = Android.Support.V7.Widget.Toolbar;
namespace XamarinSandBox.Droid.View
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("mytrains.droid.views.JourneyDetailsFragment")]
    public class FirstViewFragment:MvxFragment<FirstViewModel>
    {
        public override Android.Views.View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.FirstView, null);
        }

        public override void OnViewCreated(Android.Views.View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            var activity = (Activity as MainActivity);
            var toolbar = activity.FindViewById<Toolbar>(Resource.Id.toolbar);
            var textTitle = toolbar?.FindViewById<TextView>(Resource.Id.toolbar_title);
            if (textTitle != null)
            {
                textTitle.Text = "Awesome Calculator";
            }

        }
    }
}