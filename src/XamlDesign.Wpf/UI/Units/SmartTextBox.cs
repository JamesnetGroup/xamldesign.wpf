using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XamlDesign.Wpf.UI.Units
{
    public class SmartTextBox : TextBox
    {

        #region PlaceholderForeground

        public static readonly DependencyProperty PlaceholderForegroundProperty =
            DependencyProperty.Register(
                "PlaceholderForeground",
                typeof(Brush),
                typeof(SmartTextBox),
                new FrameworkPropertyMetadata());

        public Brush PlaceholderForeground
        {
            get => (Brush)GetValue(PlaceholderForegroundProperty);
            set => SetValue(PlaceholderForegroundProperty, value);
        }
        #endregion

        #region FocusedBorderBrush

        public static readonly DependencyProperty FocusedBorderBrushProperty =
            DependencyProperty.Register(
                "FocusedBorderBrush",
                typeof(Brush),
                typeof(SmartTextBox),
                new FrameworkPropertyMetadata());

        public Brush FocusedBorderBrush
        {
            get => (Brush)GetValue(FocusedBorderBrushProperty);
            set => SetValue(FocusedBorderBrushProperty, value);
        }
        #endregion

        static SmartTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SmartTextBox), new FrameworkPropertyMetadata(typeof(SmartTextBox)));
        }

        public static readonly DependencyProperty PlaceholderProperty = DependencyProperty.Register("Placeholder", typeof(string), typeof(SmartTextBox));

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }
    }
}
