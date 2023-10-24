using System.Windows;
using System.Windows.Controls;

namespace Jamesnet.Wpf.Component.UI.Units
{
    public class CalendarListItem : ListBoxItem
    {
        static CalendarListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CalendarListItem), new FrameworkPropertyMetadata(typeof(CalendarListItem)));
        }
    }
}
