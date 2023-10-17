using System.Windows;
using System.Windows.Controls;

namespace XamlDesign.Wpf.UI.Units
{
    public class BorderedButton : FilledButton
    {
        static BorderedButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BorderedButton), new FrameworkPropertyMetadata(typeof(BorderedButton)));
        }
    }
}
