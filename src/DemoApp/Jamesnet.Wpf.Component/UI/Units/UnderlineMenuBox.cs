using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Jamesnet.Wpf.Component.UI.Units
{
    public class UnderlineMenuBox : ListBox
    {
        #region UnderlineBrush

        public static readonly DependencyProperty UnderlineBrushProperty =
            DependencyProperty.Register(
                "UnderlineBrush",
                typeof(Brush),
                typeof(UnderlineMenuBox),
                new FrameworkPropertyMetadata());

        public Brush UnderlineBrush
        {
            get => (Brush)GetValue(UnderlineBrushProperty);
            set => SetValue(UnderlineBrushProperty, value);
        }
        #endregion

        #region Orientation

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register(
                "Orientation",
                typeof(Orientation),
                typeof(UnderlineMenuBox),
                new FrameworkPropertyMetadata());

        public Orientation Orientation
        {
            get => (Orientation)GetValue(OrientationProperty);
            set => SetValue(OrientationProperty, value);
        }
        #endregion

        #region SelectedMenuItem

        public static readonly DependencyProperty SelectedMenuItemProperty =
            DependencyProperty.Register(
                "SelectedMenuItem",
                typeof(string),
                typeof(UnderlineMenuBox),
                new FrameworkPropertyMetadata(null));

        public string SelectedMenuItem
        {
            get => (string)GetValue(SelectedMenuItemProperty);
            set => SetValue(SelectedMenuItemProperty, value);
        }
        #endregion

        static UnderlineMenuBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UnderlineMenuBox), new FrameworkPropertyMetadata(typeof(UnderlineMenuBox)));
        }

        public UnderlineMenuBox()
        {
            this.SelectionChanged += UnderlineMenuBox_SelectionChanged;
        }

        private void UnderlineMenuBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.SelectedItem is UnderlineMenuBoxItem item)
            {
                SelectedMenuItem = item.Content as string;
            }
            else
            {
                SelectedMenuItem = null;
            }
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new UnderlineMenuBoxItem();
        }
    }
}
