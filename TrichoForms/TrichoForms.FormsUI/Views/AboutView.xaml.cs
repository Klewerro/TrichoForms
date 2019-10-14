using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace TrichoForms.FormsUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxModalPresentation(WrapInNavigationPage = false)]
    public partial class AboutView : MvxContentPage
    {
        public AboutView()
        {
            InitializeComponent();
        }
    }
}