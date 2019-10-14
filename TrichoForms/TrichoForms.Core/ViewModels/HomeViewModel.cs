using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrichoForms.Core.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public List<ImageSource> Images { get; set; }


        public HomeViewModel(IMvxNavigationService navigationService) : base (navigationService)
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


        public IMvxCommand NavigateToMenuCommand => new MvxAsyncCommand(async () 
            => await NavigationService.Navigate<MainViewViewModel>().ConfigureAwait(false));


    }
}
