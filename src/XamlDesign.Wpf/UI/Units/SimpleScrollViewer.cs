using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace XamlDesign.Wpf.UI.Units
{
    public class SimpleScrollViewer : ScrollViewer
    {
        static SimpleScrollViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SimpleScrollViewer), new FrameworkPropertyMetadata(typeof(SimpleScrollViewer)));
        }

        public SimpleScrollViewer()
        {
            ScrollChanged+= OnScrollChanged;
        }

        private void OnScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            var scrollViewer = sender as ScrollViewer;
            if (scrollViewer != null)
            {
                var verticalScrollBar = scrollViewer.Template.FindName("PART_VerticalScrollBar", scrollViewer) as ScrollBar;
                var horizontalScrollBar = scrollViewer.Template.FindName("PART_HorizontalScrollBar", scrollViewer) as ScrollBar;

                if (verticalScrollBar != null)
                {
                    verticalScrollBar.Visibility = e.VerticalChange != 0 ? Visibility.Visible : Visibility.Hidden;
                }

                if (horizontalScrollBar != null)
                {
                    horizontalScrollBar.Visibility = e.HorizontalChange != 0 ? Visibility.Visible : Visibility.Hidden;
                }
            }
        }
    }
}
