using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSandBox.Core
{
    public class App:MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            RegisterAppStart(new AppStart());
        }
    }
}
