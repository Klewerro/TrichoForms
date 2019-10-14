using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace TrichoForms.Core.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {
        public AboutViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }


        public IMvxAsyncCommand CloseCommand => new MvxAsyncCommand(async () => await NavigationService.Close(this));
    }
}
