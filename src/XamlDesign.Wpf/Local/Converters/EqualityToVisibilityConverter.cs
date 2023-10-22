using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using System.Windows.Markup;

namespace XamlDesign.Wpf.Local.Converters
{
    public class EqualityToVisibilityConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return Visibility.Visible;

            string expectedValue;
            string visibilityState;

            if (parameter == null || !parameter.ToString().Contains("|"))
            {
                expectedValue = parameter?.ToString();
                visibilityState = "Collapsed"; // Default visibility state
            }
            else
            {
                string[] parameters = parameter.ToString().Split('|');
                expectedValue = parameters[0];
                visibilityState = parameters[1];
            }

            if (value.ToString() != expectedValue)
            {
                return visibilityState == "Hidden" ? Visibility.Hidden : Visibility.Collapsed;
            }

            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
