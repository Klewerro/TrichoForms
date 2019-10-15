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
        public static readonly BindableProperty SourceProperty = BindableProperty.Create(
            nameof(Source),
            typeof(ImageSource),
            typeof(CircleImage),
            propertyChanged: OnSourceChanged);

        public static readonly BindableProperty CircleSizeProperty = BindableProperty.Create(
            nameof(CircleSize),
            typeof(double),
            typeof(CircleImage),
            propertyChanged: OnSizeChanged);


        private static void OnSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as CircleImage;
            control.ImageInFrame.Source = newValue as ImageSource;
        }

        private static void OnSizeChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as CircleImage;
            control.FrameAroundImage.WidthRequest = (double)newValue;
            control.FrameAroundImage.HeightRequest = (double)newValue;
            control.FrameAroundImage.CornerRadius = (float)((double)newValue / 2);
        }


        public ImageSource Source
        {
            get => GetValue(SourceProperty) as ImageSource;
            set => SetValue(SourceProperty, value);
        }

        public double CircleSize
        {
            get => (double)GetValue(CircleSizeProperty);
            set => SetValue(CircleSizeProperty, value);
        }


        public CircleImage()
        {
            InitializeComponent();
        }
    }
}