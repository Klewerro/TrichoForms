using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using UIKit;

namespace TrichoForms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<Core.CoreApp, FormsUI.App>, Core.CoreApp, FormsUI.App>
    {
        //public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        //{
        //    global::Xamarin.Forms.Forms.Init();
        //    //global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
        //    LoadApplication(new App());

        //    return base.FinishedLaunching(app, options);
        //}
    }
}
