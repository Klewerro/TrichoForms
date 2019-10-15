using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace TrichoForms.Core.ViewModels
{
    public class MainViewViewModel : ViewModelBase
    {
        private ICommand _navigateToListCmd;
        private ICommand _navigateToAboutCmd;


        public MainViewViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }
        

        public ICommand NavigateToListViewCommand => _navigateToListCmd ?? (_navigateToListCmd = new MvxCommand(async () =>
            await NavigationService.Navigate<ListViewModel>().ConfigureAwait(false), CanExecute));

        public ICommand NavigateToAboutViewCommand => _navigateToAboutCmd ?? (_navigateToAboutCmd = new MvxCommand(async () =>
            await NavigationService.Navigate<AboutViewModel>().ConfigureAwait(false), CanExecute));

        public IMvxAsyncCommand NavigateToHomeViewCommand => new MvxAsyncCommand(async ()
            => await NavigationService.Navigate<HomeViewModel>().ConfigureAwait(false), CanExecute);


        private bool CanExecute() => true;

    }
}
