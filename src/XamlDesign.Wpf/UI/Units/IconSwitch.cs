using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XamlDesign.Wpf.UI.Units
{
    public partial class IconSwitch : ToggleSwitch
    {
        #region IconFill

        public static readonly DependencyProperty IconFillProperty =
            DependencyProperty.Register(
                "IconFill",
                typeof(Brush),
                typeof(IconSwitch),
                new FrameworkPropertyMetadata());

        public Brush IconFill
        {
            get => (Brush)GetValue(IconFillProperty);
            set => SetValue(IconFillProperty, value);
        }
        #endregion

        #region IconType

        public static readonly DependencyProperty IconTypeProperty =
            DependencyProperty.Register(
                "IconType",
                typeof(IconType),
                typeof(IconSwitch),
                new FrameworkPropertyMetadata());

        public IconType IconType
        {
            get => (IconType)GetValue(IconTypeProperty);
            set => SetValue(IconTypeProperty, value);
        }
        #endregion

        static IconSwitch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconSwitch), new FrameworkPropertyMetadata(typeof(IconSwitch)));
        }

        public IconSwitch()
        {
        }
    }
}
