using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrichoForms.Core.ViewModels
{
    public class MainViewViewModel : ViewModelBase
    {

        public MainViewViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }


        public IMvxCommand NavigateToListViewCommand => new MvxAsyncCommand(async ()
            => await NavigationService.Navigate<ListViewModel>());

        public IMvxCommand NavigateToAboutViewCommand => new MvxAsyncCommand(async ()
            => await NavigationService.Navigate<AboutViewModel>());

        public IMvxCommand NavigateToHomeViewCommand => new MvxAsyncCommand(async ()
            => await NavigationService.Navigate<HomeViewModel>());

    }
}
