using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using XamarinSandBox.Core.ViewModels;

namespace XamarinSandBox.Droid.View
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.left_drawer, true)]
    [Register("xamarinsandbox.droid.view.MenuFragment")]
    public class MenuFragment:MvxFragment<MenuViewModel>, NavigationView.IOnNavigationItemSelectedListener
    {
        private NavigationView _navigationView;
        private IMenuItem _previousMenuItem;
        public override Android.Views.View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore= base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.fragment_navigation, null);

            _navigationView = view.FindViewById<NavigationView>(Resource.Id.navigation_view);
            _navigationView.SetNavigationItemSelectedListener(this);
            _navigationView.Menu.FindItem(Resource.Id.nav_home).SetChecked(true);

            return view;
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            if (item != _previousMenuItem)
            {
                _previousMenuItem?.SetChecked(false);
            }

            item.SetCheckable(true);
            item.SetChecked(true);

            _previousMenuItem = item;

            //Navigate(item.ItemId);

            return true;
        }
    }
}