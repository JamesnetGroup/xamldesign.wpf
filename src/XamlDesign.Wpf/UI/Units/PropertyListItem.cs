using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XamlDesign.Wpf.UI.Units
{
    public class PropertyListItem : ListBoxItem
    {
        #region HeaderBackground

        public static readonly DependencyProperty HeaderBackgroundProperty =
            DependencyProperty.Register(
                "HeaderBackground",
                typeof(Brush),
                typeof(PropertyListItem),
                new FrameworkPropertyMetadata());

        public Brush HeaderBackground
        {
            get => (Brush)GetValue(HeaderBackgroundProperty);
            set => SetValue(HeaderBackgroundProperty, value);
        }
        #endregion

        #region HeaderForeground

        public static readonly DependencyProperty HeaderForegroundProperty =
            DependencyProperty.Register(
                "HeaderForeground",
                typeof(Brush),
                typeof(PropertyListItem),
                new FrameworkPropertyMetadata());

        public Brush HeaderForeground
        {
            get => (Brush)GetValue(HeaderForegroundProperty);
            set => SetValue(HeaderForegroundProperty, value);
        }
        #endregion
        static PropertyListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PropertyListItem), new FrameworkPropertyMetadata(typeof(PropertyListItem)));
        }
    }
}