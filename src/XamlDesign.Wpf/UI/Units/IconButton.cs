using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XamlDesign.Wpf.UI.Units
{
    public class IconButton : FilledButton
    {
        #region IconBackground

        public static readonly DependencyProperty IconBackgroundProperty =
            DependencyProperty.Register(
                "IconBackground",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush IconBackground
        {
            get => (Brush)GetValue(IconBackgroundProperty);
            set => SetValue(IconBackgroundProperty, value);
        }
        #endregion

        #region HeaderBackground

        public static readonly DependencyProperty HeaderBackgroundProperty =
            DependencyProperty.Register(
                "HeaderBackground",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush HeaderBackground
        {
            get => (Brush)GetValue(HeaderBackgroundProperty);
            set => SetValue(HeaderBackgroundProperty, value);
        }
        #endregion

        #region HeaderBorderBrush

        public static readonly DependencyProperty HeaderBorderBrushProperty =
            DependencyProperty.Register(
                "HeaderBorderBrush",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush HeaderBorderBrush
        {
            get => (Brush)GetValue(HeaderBorderBrushProperty);
            set => SetValue(HeaderBorderBrushProperty, value);
        }
        #endregion

        #region IconMouseOverBackground

        public static readonly DependencyProperty IconMouseOverBackgroundProperty =
            DependencyProperty.Register(
                "IconMouseOverBackground",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush IconMouseOverBackground
        {
            get => (Brush)GetValue(IconMouseOverBackgroundProperty);
            set => SetValue(IconMouseOverBackgroundProperty, value);
        }
        #endregion

        #region HeaderMouseOverBackground

        public static readonly DependencyProperty HeaderMouseOverBackgroundProperty =
            DependencyProperty.Register(
                "HeaderMouseOverBackground",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush HeaderMouseOverBackground
        {
            get => (Brush)GetValue(HeaderMouseOverBackgroundProperty);
            set => SetValue(HeaderMouseOverBackgroundProperty, value);
        }
        #endregion

        #region HeaderMouseOverBorderBrush

        public static readonly DependencyProperty HeaderMouseOverBorderBrushProperty =
            DependencyProperty.Register(
                "HeaderMouseOverBorderBrush",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush HeaderMouseOverBorderBrush
        {
            get => (Brush)GetValue(HeaderMouseOverBorderBrushProperty);
            set => SetValue(HeaderMouseOverBorderBrushProperty, value);
        }
        #endregion

        #region IconPressedBackground

        public static readonly DependencyProperty IconPressedBackgroundProperty =
            DependencyProperty.Register(
                "IconPressedBackground",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush IconPressedBackground
        {
            get => (Brush)GetValue(IconPressedBackgroundProperty);
            set => SetValue(IconPressedBackgroundProperty, value);
        }
        #endregion

        #region HeaderPressedBackground

        public static readonly DependencyProperty HeaderPressedBackgroundProperty =
            DependencyProperty.Register(
                "HeaderPressedBackground",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush HeaderPressedBackground
        {
            get => (Brush)GetValue(HeaderPressedBackgroundProperty);
            set => SetValue(HeaderPressedBackgroundProperty, value);
        }
        #endregion

        #region HeaderPressedBorderBrush

        public static readonly DependencyProperty HeaderPressedBorderBrushProperty =
            DependencyProperty.Register(
                "HeaderPressedBorderBrush",
                typeof(Brush),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Brush HeaderPressedBorderBrush
        {
            get => (Brush)GetValue(HeaderPressedBorderBrushProperty);
            set => SetValue(HeaderPressedBorderBrushProperty, value);
        }
        #endregion

        #region HeaderBorderThickness

        public static readonly DependencyProperty HeaderBorderThicknessProperty =
            DependencyProperty.Register(
                "HeaderBorderThickness",
                typeof(Thickness),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Thickness HeaderBorderThickness
        {
            get => (Thickness)GetValue(HeaderBorderThicknessProperty);
            set => SetValue(HeaderBorderThicknessProperty, value);
        }
        #endregion

        #region HeaderMargin

        public static readonly DependencyProperty HeaderMarginProperty =
            DependencyProperty.Register(
                "HeaderMargin",
                typeof(Thickness),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Thickness HeaderMargin
        {
            get => (Thickness)GetValue(HeaderMarginProperty);
            set => SetValue(HeaderMarginProperty, value);
        }
        #endregion

        #region HeaderPadding

        public static readonly DependencyProperty HeaderPaddingProperty =
            DependencyProperty.Register(
                "HeaderPadding",
                typeof(Thickness),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public Thickness HeaderPadding
        {
            get => (Thickness)GetValue(HeaderPaddingProperty);
            set => SetValue(HeaderPaddingProperty, value);
        }
        #endregion

        #region Icon

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
                "Icon",
                typeof(IconType),
                typeof(IconButton),
                new FrameworkPropertyMetadata());

        public IconType Icon
        {
            get => (IconType)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
        #endregion

        #region IconWidth

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register(
                "IconWidth",
                typeof(double),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public double IconWidth
        {
            get => (double)GetValue(IconWidthProperty);
            set => SetValue(IconWidthProperty, value);
        }
        #endregion

        #region IconHeight

        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register(
                "IconHeight",
                typeof(double),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public double IconHeight
        {
            get => (double)GetValue(IconHeightProperty);
            set => SetValue(IconHeightProperty, value);
        }
        #endregion

        #region IsIconOnly

        public static readonly DependencyProperty IsIconOnlyProperty =
            DependencyProperty.Register(
                "IsIconOnly",
                typeof(bool),
                typeof(FilledButton),
                new FrameworkPropertyMetadata());

        public bool IsIconOnly
        {
            get => (bool)GetValue(IsIconOnlyProperty);
            set => SetValue(IsIconOnlyProperty, value);
        }
        #endregion

        static IconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconButton), new FrameworkPropertyMetadata(typeof(IconButton)));
        }
    }
}
