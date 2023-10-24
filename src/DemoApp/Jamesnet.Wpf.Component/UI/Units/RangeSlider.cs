using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Jamesnet.Wpf.Component.UI.Units
{
    public class RangeSlider : Control
    {
        #region TrackBackground

        public static readonly DependencyProperty TrackBackgroundProperty =
            DependencyProperty.Register(
                "TrackBackground",
                typeof(Brush),
                typeof(RangeSlider),
                new FrameworkPropertyMetadata());

        public Brush TrackBackground
        {
            get => (Brush)GetValue(TrackBackgroundProperty);
            set => SetValue(TrackBackgroundProperty, value);
        }
        #endregion

        #region TrackRangeBackground

        public static readonly DependencyProperty TrackRangeBackgroundProperty =
            DependencyProperty.Register(
                "TrackRangeBackground",
                typeof(Brush),
                typeof(RangeSlider),
                new FrameworkPropertyMetadata());

        public Brush TrackRangeBackground
        {
            get => (Brush)GetValue(TrackRangeBackgroundProperty);
            set => SetValue(TrackRangeBackgroundProperty, value);
        }
        #endregion

        #region MaximumProperty

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register(
                "Maximum",
                typeof(double),
                typeof(RangeSlider),
                new FrameworkPropertyMetadata(100.0));

        public double Maximum
        {
            get => (double)GetValue(MaximumProperty);
            set => SetValue(MaximumProperty, value);
        }
        #endregion

        #region MinimumProperty

        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register(
                "Minimum",
                typeof(double),
                typeof(RangeSlider),
                new FrameworkPropertyMetadata(0.0));

        public double Minimum
        {
            get => (double)GetValue(MinimumProperty);
            set => SetValue(MinimumProperty, value);
        }
        #endregion

        #region LeftValueProperty

        public static readonly DependencyProperty LeftValueProperty =
            DependencyProperty.Register(
                "LeftValue",
                typeof(double),
                typeof(RangeSlider),
                new FrameworkPropertyMetadata(0.0, OnLeftValueChanged));

        public double LeftValue
        {
            get => (double)GetValue(LeftValueProperty);
            set => SetValue(LeftValueProperty, value);
        }
        #endregion

        #region RightValueProperty

        public static readonly DependencyProperty RightValueProperty =
            DependencyProperty.Register(
                "RightValue",
                typeof(double),
                typeof(RangeSlider),
                new FrameworkPropertyMetadata(100.0, OnRightValueChanged));

        public double RightValue
        {
            get => (double)GetValue(RightValueProperty);
            set => SetValue(RightValueProperty, value);
        }
        #endregion

        private Thumb leftThumb;
        private Thumb rightThumb;
        private Canvas containerCanvas;
        private Rectangle selectedRange;

        static RangeSlider()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RangeSlider), new FrameworkPropertyMetadata(typeof(RangeSlider)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            leftThumb = GetTemplateChild("PART_LeftThumb") as Thumb;
            rightThumb = GetTemplateChild("PART_RightThumb") as Thumb;
            containerCanvas = GetTemplateChild("PART_Canvas") as Canvas;
            selectedRange = GetTemplateChild("PART_SelectedRange") as Rectangle;

            if (containerCanvas != null)
            {
                containerCanvas.SizeChanged += (s, e) => UpdateInitialPosition();
                containerCanvas.Loaded += (s, e) => SetThumbsByValues();
            }

            if (leftThumb != null)
            {
                leftThumb.DragDelta += LeftThumb_DragDelta;
            }

            if (rightThumb != null)
            {
                rightThumb.DragDelta += RightThumb_DragDelta;
            }

            UpdateSelectedRange();
        }

        private static void OnLeftValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var slider = d as RangeSlider;
            slider?.SetThumbsByValues();
        }

        private static void OnRightValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var slider = d as RangeSlider;
            slider?.SetThumbsByValues();
        }

        private void SetThumbsByValues()
        {
            if (containerCanvas != null && leftThumb != null && rightThumb != null)
            {
                double width = containerCanvas.ActualWidth - leftThumb.ActualWidth;
                Canvas.SetLeft(leftThumb, width * (LeftValue - Minimum) / (Maximum - Minimum));
                Canvas.SetLeft(rightThumb, width * (RightValue - Minimum) / (Maximum - Minimum));
                UpdateSelectedRange();
            }
        }

        private void UpdateInitialPosition()
        {
            if (leftThumb != null)
            {
                Canvas.SetLeft(leftThumb, 0);
            }

            if (rightThumb != null)
            {
                Canvas.SetLeft(rightThumb, containerCanvas.ActualWidth - rightThumb.ActualWidth);
            }

            UpdateSelectedRange();
        }

        private void UpdateSelectedRange()
        {
            if (selectedRange != null && leftThumb != null && rightThumb != null)
            {
                double leftPos = Canvas.GetLeft(leftThumb) + (leftThumb.ActualWidth / 2);
                double rightPos = Canvas.GetLeft(rightThumb) + (rightThumb.ActualWidth / 2);

                Canvas.SetLeft(selectedRange, leftPos);
                selectedRange.Width = Math.Max(0, rightPos - leftPos);
            }
        }

        private void LeftThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            double newLeft = Canvas.GetLeft(leftThumb) + e.HorizontalChange;
            newLeft = Math.Max(0, newLeft);
            newLeft = Math.Min(Canvas.GetLeft(rightThumb), newLeft);
            Canvas.SetLeft(leftThumb, newLeft);
            LeftValue = Minimum + (newLeft / (containerCanvas.ActualWidth - leftThumb.ActualWidth)) * (Maximum - Minimum);
            UpdateSelectedRange();
        }

        private void RightThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            double newLeft = Canvas.GetLeft(rightThumb) + e.HorizontalChange;
            newLeft = Math.Max(Canvas.GetLeft(leftThumb), newLeft);
            newLeft = Math.Min(containerCanvas.ActualWidth - rightThumb.ActualWidth, newLeft);
            Canvas.SetLeft(rightThumb, newLeft);
            RightValue = Minimum + (newLeft / (containerCanvas.ActualWidth - rightThumb.ActualWidth)) * (Maximum - Minimum);
            UpdateSelectedRange();
        }
    }
}
