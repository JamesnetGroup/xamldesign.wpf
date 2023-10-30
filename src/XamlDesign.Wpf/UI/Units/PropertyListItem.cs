using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XamlDesign.Wpf.UI.Units
{
    public class PropertyListItem : ListBoxItem
    {
        #region HeaderBackground

        public static readonly DependencyProperty HeaderBackgroundProperty =
            DependencyProperty.RegisterAttached(
                "HeaderBackground",
                typeof(Brush),
                typeof(PropertyListItem),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));

        public Brush HeaderBackground
        {
            get => (Brush)GetValue(HeaderBackgroundProperty);
            set => SetValue(HeaderBackgroundProperty, value);
        }
        #endregion

        #region HeaderForeground

        public static readonly DependencyProperty HeaderForegroundProperty =
            DependencyProperty.RegisterAttached(
                "HeaderForeground",
                typeof(Brush),
                typeof(PropertyListItem),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetHeaderForeground(UIElement element, Brush value)
        {
            element.SetValue(HeaderForegroundProperty, value);
        }

        public static Brush GetHeaderForeground(UIElement element)
        {
            return (Brush)element.GetValue(HeaderForegroundProperty);
        }
        #endregion
        static PropertyListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PropertyListItem), new FrameworkPropertyMetadata(typeof(PropertyListItem)));
        }
    }
}