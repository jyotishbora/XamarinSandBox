using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using XamarinSandBox.Core.ViewModels;

namespace XamarinSandBox.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {

            ShowViewModel<LoginViewModel>();

        }
    }
}
