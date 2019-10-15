using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace TrichoForms.FormsUI.Converters
{
    public class ImageToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var imageString = value as string;
            if (string.IsNullOrEmpty(imageString))
                return null;

            return ImageSource.FromStream(() => new MemoryStream(System.Convert.FromBase64String(imageString)));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
