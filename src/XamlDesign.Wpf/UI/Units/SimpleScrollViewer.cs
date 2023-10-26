using System.Windows;
using System.Windows.Controls;

namespace XamlDesign.Wpf.UI.Units
{
    public class SimpleScrollViewer : ScrollViewer
    {
        static SimpleScrollViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SimpleScrollViewer), new FrameworkPropertyMetadata(typeof(SimpleScrollViewer)));
        }
    }
}
