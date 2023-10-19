using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XamlDesign.Wpf.UI.Units
{
    public class RadioExpander : RadioButton
    {
        #region HeaderBackground

        public static readonly DependencyProperty HeaderBackgroundProperty =
            DependencyProperty.Register(
                "HeaderBackground",
                typeof(Brush),
                typeof(RadioExpander),
                new FrameworkPropertyMetadata());

        public Brush HeaderBackground
        {
            get => (Brush)GetValue(HeaderBackgroundProperty);
            set => SetValue(HeaderBackgroundProperty, value);
        }
        #endregion

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
