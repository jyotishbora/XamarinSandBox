using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace XamarinSandBox.Core.ViewModels
{
    public class MainViewModel:MvxViewModel
    {
        public void ShowMenu()
        {
            ShowViewModel<MenuViewModel>();
        }

        public void ShowFirstViewModel()
        {
            ShowViewModel<FirstViewModel>();
        }
    }
}
