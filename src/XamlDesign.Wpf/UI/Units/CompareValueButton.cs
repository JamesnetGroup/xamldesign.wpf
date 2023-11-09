using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XamlDesign.Wpf.UI.Units
{
    public class CompareValueButton : IconButton
    {
        #region Value1Property

        public static readonly DependencyProperty Value1Property =
            DependencyProperty.Register(
                nameof(Value1),
                typeof(object),
                typeof(CompareValueButton),
                new FrameworkPropertyMetadata(null));

        public object Value1
        {
            get => GetValue(Value1Property);
            set => SetValue(Value1Property, value);
        }

        #endregion

        #region Value2Property

        public static readonly DependencyProperty Value2Property =
            DependencyProperty.Register(
                nameof(Value2),
                typeof(object),
                typeof(CompareValueButton),
                new FrameworkPropertyMetadata(null)); 

        public object Value2
        {
            get => GetValue(Value2Property);
            set => SetValue(Value2Property, value);
        }
        #endregion

        #region Value1TemplateProperty

        public static readonly DependencyProperty Value1TemplateProperty =
            DependencyProperty.Register(
                nameof(Value1Template),
                typeof(DataTemplate),
                typeof(CompareValueButton),
                new FrameworkPropertyMetadata(null));

        public DataTemplate Value1Template
        {
            get => (DataTemplate)GetValue(Value1TemplateProperty);
            set => SetValue(Value1TemplateProperty, value);
        }

        #endregion

        #region Value2TemplateProperty

        public static readonly DependencyProperty Value2TemplateProperty =
            DependencyProperty.Register(
                nameof(Value2Template),
                typeof(DataTemplate),
                typeof(CompareValueButton),
                new FrameworkPropertyMetadata(null));

        public DataTemplate Value2Template
        {
            get => (DataTemplate)GetValue(Value2TemplateProperty);
            set => SetValue(Value2TemplateProperty, value);
        }
        #endregion

        #region Value1Foreground

        public static readonly DependencyProperty Value1ForegroundProperty =
            DependencyProperty.Register(
                "Value1Foreground",
                typeof(Brush),
                typeof(IconButton),
                new FrameworkPropertyMetadata());

        public Brush Value1Foreground
        {
            get => (Brush)GetValue(Value1ForegroundProperty);
            set => SetValue(Value1ForegroundProperty, value);
        }
        #endregion

        #region Value2Foreground

        public static readonly DependencyProperty Value2ForegroundProperty =
            DependencyProperty.Register(
                "Value2Foreground",
                typeof(Brush),
                typeof(IconButton),
                new FrameworkPropertyMetadata());

        public Brush Value2Foreground
        {
            get => (Brush)GetValue(Value2ForegroundProperty);
            set => SetValue(Value2ForegroundProperty, value);
        }
        #endregion

        static CompareValueButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CompareValueButton), new FrameworkPropertyMetadata(typeof(CompareValueButton)));
        }
    }
}
