using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TrichoForms.Core.Models;
using Xamarin.Forms;

namespace TrichoForms.FormsUI.Converters
{
    public class ListItemSelectedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;


            var selectedItemArgs = value as SelectedItemChangedEventArgs;
            return selectedItemArgs.SelectedItem as ListItem;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
