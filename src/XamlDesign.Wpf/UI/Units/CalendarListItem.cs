using System.Windows;
using System.Windows.Controls;

namespace XamlDesign.Wpf.UI.Units
{
    public class CalendarListItem : ListBoxItem
    {
        static CalendarListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CalendarListItem), new FrameworkPropertyMetadata(typeof(CalendarListItem)));
        }
    }
}
