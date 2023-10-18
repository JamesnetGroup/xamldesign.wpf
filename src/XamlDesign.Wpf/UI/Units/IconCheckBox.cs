using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XamlDesign.Wpf.UI.Units
{
    public class IconCheckBox : CheckBox
    {
        #region IconBackground

        public static readonly DependencyProperty IconBackgroundProperty =
            DependencyProperty.Register(
                "IconBackground",
                typeof(Brush),
                typeof(IconCheckBox),
                new FrameworkPropertyMetadata());

        public Brush IconBackground
        {
            get => (Brush)GetValue(IconBackgroundProperty);
            set => SetValue(IconBackgroundProperty, value);
        }
        #endregion

        #region IconCheckedBackground

        public static readonly DependencyProperty IconCheckedBackgroundProperty =
            DependencyProperty.Register(
                "IconCheckedBackground",
                typeof(Brush),
                typeof(IconCheckBox),
                new FrameworkPropertyMetadata());

        public Brush IconCheckedBackground
        {
            get => (Brush)GetValue(IconCheckedBackgroundProperty);
            set => SetValue(IconCheckedBackgroundProperty, value);
        }
        #endregion

        static IconCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconCheckBox), new FrameworkPropertyMetadata(typeof(IconCheckBox)));
        }
    }
}
