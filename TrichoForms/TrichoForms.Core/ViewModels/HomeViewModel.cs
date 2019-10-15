using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrichoForms.Core.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TrichoForms.Core.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private const string FIRST_START_KEY = "first_start";

        public List<ImageSource> Images { get; set; }


        public HomeViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }

        public override void Prepare()
        {
            Images = new List<ImageSource>
            {
                ImageSource.FromFile("Carousel_image_1.png"),
                ImageSource.FromFile("Carousel_image_2.png"),
                ImageSource.FromFile("Carousel_image_3.png")
            };
        }

        public override void ViewCreated()
        {
            var isNavButtonVisible = Preferences.Get(FIRST_START_KEY, 0) < 2;
            if (!isNavButtonVisible)
            {
                MessagingCenter.Send<HomeViewModel, bool>(this, "HideToolbarItems", isNavButtonVisible);
            }
        }


        public IMvxCommand NavigateToMenuCommand => new MvxAsyncCommand(async () =>
        {
            Preferences.Set(FIRST_START_KEY, (int)HomeStates.SecondTimeStart);
            await NavigationService.Navigate<MainViewViewModel>().ConfigureAwait(false);
        });


    }
}
