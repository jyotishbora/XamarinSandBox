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

namespace XamarinSandBox.Droid
{
	[MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
	[Register("mytrains.droid.views.HomeFragment")]
	public class HomeFragment : MvxFragment<HomeViewModel>
	{
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your fragment here
		}

		public override Android.Views.View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
            // Use this to return your custom view for this Fragment

            base.OnCreateView(inflater, container, savedInstanceState);
            return inflater.Inflate(Resource.Layout.fragment_home, container, false);

        }
	}
}
