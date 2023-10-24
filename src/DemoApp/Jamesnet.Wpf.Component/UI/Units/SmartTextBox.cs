using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Jamesnet.Wpf.Component.UI.Units
{
    public class SmartTextBox : TextBox
    {
        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(SmartTextBox), new PropertyMetadata(null));
        #endregion

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

        #region FocusedForeground

        public static readonly DependencyProperty FocusedForegroundProperty =
            DependencyProperty.Register(
                "FocusedForeground",
                typeof(Brush),
                typeof(SmartTextBox),
                new FrameworkPropertyMetadata());

        public Brush FocusedForeground
        {
            get => (Brush)GetValue(FocusedForegroundProperty);
            set => SetValue(FocusedForegroundProperty, value);
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

        #region FocusedBackground

        public static readonly DependencyProperty FocusedBackgroundProperty =
            DependencyProperty.Register(
                "FocusedBackground",
                typeof(Brush),
                typeof(SmartTextBox),
                new FrameworkPropertyMetadata());

        public Brush FocusedBackground
        {
            get => (Brush)GetValue(FocusedBackgroundProperty);
            set => SetValue(FocusedBackgroundProperty, value);
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
