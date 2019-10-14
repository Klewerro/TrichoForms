using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrichoForms.Core.ViewModels
{
    public class ViewModelBase : MvxViewModel
    {
        protected IMvxNavigationService NavigationService { get; private set; }

        public ViewModelBase(IMvxNavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}
