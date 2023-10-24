using System.Windows;
using System.Windows.Controls;

namespace Jamesnet.Wpf.Component.UI.Units
{
    public class VerticalSeparator : Control
    {
        static VerticalSeparator()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VerticalSeparator), new FrameworkPropertyMetadata(typeof(VerticalSeparator)));
        }
    }
}
