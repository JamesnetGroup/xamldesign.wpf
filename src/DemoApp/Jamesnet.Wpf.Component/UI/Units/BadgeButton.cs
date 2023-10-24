using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Jamesnet.Wpf.Component.UI.Units
{
    public class BadgeButton : IconButton
    {

        static BadgeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BadgeButton), new FrameworkPropertyMetadata(typeof(BadgeButton)));
        }

    }
}
