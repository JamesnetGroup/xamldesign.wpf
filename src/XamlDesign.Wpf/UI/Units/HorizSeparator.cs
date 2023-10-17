using System.Windows;
using System.Windows.Controls;

namespace XamlDesign.Wpf.UI.Units
{
    public class HorizSeparator : Control
    {
        static HorizSeparator()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HorizSeparator), new FrameworkPropertyMetadata(typeof(HorizSeparator)));
        }
    }
}
