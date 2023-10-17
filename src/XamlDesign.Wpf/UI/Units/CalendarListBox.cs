using System.Windows;
using System.Windows.Controls;

namespace XamlDesign.Wpf.UI.Units
{
    public class CalendarListBox : ListBox
    {
        static CalendarListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CalendarListBox), new FrameworkPropertyMetadata(typeof(CalendarListBox)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new CalendarListItem();
        }
    }
}
