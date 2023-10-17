using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using DependencyPropertyGenerator;

namespace XamlDesign.Wpf.UI.Units
{
    public partial class ToggleRadioSwitch : RadioButton
    {
        #region CheckedBackground

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.Register(
                "CheckedBackground",
                typeof(Brush),
                typeof(ToggleRadioSwitch),
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
                typeof(ToggleRadioSwitch),
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
                typeof(ToggleRadioSwitch),
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
                typeof(ToggleRadioSwitch),
                new FrameworkPropertyMetadata());

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
        #endregion

        #region ButtonCornerRadius

        public static readonly DependencyProperty ButtonCornerRadiusProperty =
            DependencyProperty.Register(
                "ButtonCornerRadius",
                typeof(CornerRadius),
                typeof(ToggleRadioSwitch),
                new FrameworkPropertyMetadata());

        public CornerRadius ButtonCornerRadius
        {
            get => (CornerRadius)GetValue(ButtonCornerRadiusProperty);
            set => SetValue(ButtonCornerRadiusProperty, value);
        }
        #endregion

        static ToggleRadioSwitch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ToggleRadioSwitch), new FrameworkPropertyMetadata(typeof(ToggleRadioSwitch)));
        }

        public ToggleRadioSwitch()
        { 
        }
    }
}
