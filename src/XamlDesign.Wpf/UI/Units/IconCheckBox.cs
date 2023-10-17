using System.Windows;
using System.Windows.Controls;

namespace XamlDesign.Wpf.UI.Units
{
    public class IconCheckBox : CheckBox
    {
        static IconCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconCheckBox), new FrameworkPropertyMetadata(typeof(IconCheckBox)));
        }
    }
}
