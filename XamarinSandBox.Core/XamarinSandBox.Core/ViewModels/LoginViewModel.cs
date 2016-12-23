using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace XamarinSandBox.Core.ViewModels
{
    public class LoginViewModel:MvxViewModel
    {
        private string _username;
        private string _password;

        public string UserName
        {
            get { return _username; }
            set
            {
                SetProperty(ref _username, value);
                RaisePropertyChanged(() => UserName);
            }
        }

        public string Password
        {
            get { return _password;}
            set
            {
                SetProperty(ref _password, value);
                RaisePropertyChanged(()=>Password);
            }
        }

       
        public IMvxCommand LoginCommand => new MvxCommand(AttemptLogin,CanExecuteLogin);

        private void AttemptLogin()
        {
            ShowViewModel<MainViewModel>();
        }

        private bool CanExecuteLogin()
        {
            return (!string.IsNullOrEmpty(UserName) || !string.IsNullOrWhiteSpace(UserName))
                   && (!string.IsNullOrEmpty(Password) || !string.IsNullOrWhiteSpace(Password));
        }
    }
}
