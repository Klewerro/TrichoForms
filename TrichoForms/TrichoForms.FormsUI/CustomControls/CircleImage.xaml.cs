using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrichoForms.FormsUI.CustomControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CircleImage : ContentView
    {
        public static BindableProperty ImageSourceProperty = BindableProperty.Create(
            "ImageSource",
            typeof(ImageSource),
            typeof(ImageSource));


        public ImageSource ImageSource
        {
            get => GetValue(ImageSourceProperty) as ImageSource;
            set
            {
                SetValue(ImageSourceProperty, value);
                ImageInside.Source = value;
            }
        }


        public CircleImage()
        {
            InitializeComponent();
        }
    }
}