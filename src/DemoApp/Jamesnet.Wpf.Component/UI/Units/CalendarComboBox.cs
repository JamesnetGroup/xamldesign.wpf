using System.Windows;
using System.Windows.Controls;

namespace Jamesnet.Wpf.Component.UI.Units
{
    public class CalendarComboBox : ComboBox
    {
        static CalendarComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CalendarComboBox), new FrameworkPropertyMetadata(typeof(CalendarComboBox)));
        }
    }
}
