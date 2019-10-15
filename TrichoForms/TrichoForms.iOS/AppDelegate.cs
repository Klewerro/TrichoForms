using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using UIKit;

namespace TrichoForms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<Core.CoreApp, FormsUI.App>, Core.CoreApp, FormsUI.App>
    {
        public override bool WillFinishLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            global::Xamarin.Forms.FormsMaterial.Init();
            return base.WillFinishLaunching(uiApplication, launchOptions);
        }
    }
}
