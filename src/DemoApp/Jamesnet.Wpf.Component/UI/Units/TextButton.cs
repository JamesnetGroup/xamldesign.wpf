using System.Windows;
using System.Windows.Controls;

namespace Jamesnet.Wpf.Component.UI.Units
{
    public class TextButton : FilledButton
    {
        static TextButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextButton), new FrameworkPropertyMetadata(typeof(TextButton)));
        }
    }
}
