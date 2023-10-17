using System.Windows;
using System.Windows.Controls;

namespace XamlDesign.Wpf.UI.Units
{
    public class RadioExpander : RadioButton
    {

        public static readonly DependencyProperty StartDateHeaderProperty =
            DependencyProperty.Register("StartDateHeader", typeof(DateTime?), typeof(RadioExpander), new PropertyMetadata(null, CHanged));

        private static void CHanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        public DateTime? StartDateHeader
        {
            get { return (DateTime?)GetValue(StartDateHeaderProperty); }
            set { SetValue(StartDateHeaderProperty, value); }
        }

        public static readonly DependencyProperty EndDateHeaderProperty =
            DependencyProperty.Register("EndDateHeader", typeof(DateTime?), typeof(RadioExpander), new PropertyMetadata(null));

        public DateTime? EndDateHeader
        {
            get { return (DateTime?)GetValue(EndDateHeaderProperty); }
            set { SetValue(EndDateHeaderProperty, value); }
        }

        static RadioExpander()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadioExpander), new FrameworkPropertyMetadata(typeof(RadioExpander)));
        }
    }
}
