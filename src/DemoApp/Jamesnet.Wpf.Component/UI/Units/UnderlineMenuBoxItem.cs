using Jamesnet.Wpf.Controls;
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
    public class UnderlineMenuBoxItem : ListBoxItem
    {
        #region Icon

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
                "Icon",
                typeof(IconType),
                typeof(UnderlineMenuBoxItem),
                new FrameworkPropertyMetadata());

        public IconType Icon
        {
            get => (IconType)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
        #endregion


        static UnderlineMenuBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UnderlineMenuBoxItem), new FrameworkPropertyMetadata(typeof(UnderlineMenuBoxItem)));
        }
    }
}
