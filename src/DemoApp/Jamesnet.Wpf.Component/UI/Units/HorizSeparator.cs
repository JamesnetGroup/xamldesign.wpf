using System.Windows;
using System.Windows.Controls;

namespace Jamesnet.Wpf.Component.UI.Units
{
    public class HorizSeparator : Control
    {
        static HorizSeparator()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HorizSeparator), new FrameworkPropertyMetadata(typeof(HorizSeparator)));
        }
    }
}
