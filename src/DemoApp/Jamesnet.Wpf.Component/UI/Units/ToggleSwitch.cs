using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Jamesnet.Wpf.Component.UI.Units
{
    public partial class ToggleSwitch : CheckBox
    {
        #region CheckedBackground

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.Register(
                "CheckedBackground",
                typeof(Brush),
                typeof(ToggleSwitch),
                new FrameworkPropertyMetadata());

        public Brush CheckedBackground
        {
            get => (Brush)GetValue(CheckedBackgroundProperty);
            set => SetValue(CheckedBackgroundProperty, value);
        }
        #endregion

        #region MouseOverBackground

        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register(
                "MouseOverBackground",
                typeof(Brush),
                typeof(ToggleSwitch),
                new FrameworkPropertyMetadata());

        public Brush MouseOverBackground
        {
            get => (Brush)GetValue(MouseOverBackgroundProperty);
            set => SetValue(MouseOverBackgroundProperty, value);
        }
        #endregion

        #region ButtonBackground

        public static readonly DependencyProperty ButtonBackgroundProperty =
            DependencyProperty.Register(
                "ButtonBackground",
                typeof(Brush),
                typeof(ToggleSwitch),
                new FrameworkPropertyMetadata());

        public Brush ButtonBackground
        {
            get => (Brush)GetValue(ButtonBackgroundProperty);
            set => SetValue(ButtonBackgroundProperty, value);
        }
        #endregion

        #region CornerRadius

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(
                "CornerRadius",
                typeof(CornerRadius),
                typeof(ToggleSwitch),
                new FrameworkPropertyMetadata());

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
        #endregion

        static ToggleSwitch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ToggleSwitch), new FrameworkPropertyMetadata(typeof(ToggleSwitch)));
        }

        public ToggleSwitch()
        {
        }
    }
}
