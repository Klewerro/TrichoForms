using MvvmCross.Forms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrichoForms.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrichoForms.FormsUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : MvxContentPage<MainViewViewModel>
    {
        public MainView()
        {
            InitializeComponent();
        }
    }
}