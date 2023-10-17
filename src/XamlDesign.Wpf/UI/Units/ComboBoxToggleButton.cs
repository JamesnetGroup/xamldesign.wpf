using System.Windows;
using System.Windows.Controls.Primitives;

namespace XamlDesign.Wpf.UI.Units
{
    public class ComboBoxToggleButton : ToggleButton
    {
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(ComboBoxToggleButton), new PropertyMetadata(null));

        static ComboBoxToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ComboBoxToggleButton), new FrameworkPropertyMetadata(typeof(ComboBoxToggleButton)));
        }
    }
}