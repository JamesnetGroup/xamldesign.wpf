using System.Windows;
using System.Windows.Controls;

namespace XamlDesign.Wpf.UI.Units
{
    public class DateRangeSelector : Control
    {
        static DateRangeSelector()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DateRangeSelector), new FrameworkPropertyMetadata(typeof(DateRangeSelector)));
        }

        public static readonly DependencyProperty SelectedStartDateProperty =
            DependencyProperty.Register("SelectedStartDate", typeof(DateTime?), typeof(DateRangeSelector), new FrameworkPropertyMetadata(null, OnSelectedStartDateChanged));

        public DateTime? SelectedStartDate
        {
            get { return (DateTime?)GetValue(SelectedStartDateProperty); }
            set { SetValue(SelectedStartDateProperty, value); }
        }

        public static readonly DependencyProperty SelectedEndDateProperty =
            DependencyProperty.Register("SelectedEndDate", typeof(DateTime?), typeof(DateRangeSelector), new FrameworkPropertyMetadata(null, OnSelectedEndDateChanged));

        public DateTime? SelectedEndDate
        {
            get { return (DateTime?)GetValue(SelectedEndDateProperty); }
            set { SetValue(SelectedEndDateProperty, value); }
        }

        public static readonly DependencyProperty StartDateProperty = DependencyProperty.Register(
            "StartDate", typeof(DateTime), typeof(DateRangeSelector), new PropertyMetadata(DateTime.Now.AddMonths(-1), OnDateChanged));


        public DateTime StartDate
        {
            get { return (DateTime)GetValue(StartDateProperty); }
            set { SetValue(StartDateProperty, value); }
        }

        public static readonly DependencyProperty EndDateProperty = DependencyProperty.Register(
            "EndDate", typeof(DateTime), typeof(DateRangeSelector), new PropertyMetadata(DateTime.Now.AddMonths(0), OnDateChanged));

        public DateTime EndDate
        {
            get { return (DateTime)GetValue(EndDateProperty); }
            set { SetValue(EndDateProperty, value); }
        }

        private static void OnDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private DateTime? _lastSelectedDate;
        private RangeCalendar _startCalendar;
        private RangeCalendar _endCalendar;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _startCalendar = GetTemplateChild("StartDateCalendar") as RangeCalendar;
            _endCalendar = GetTemplateChild("EndDateCalendar") as RangeCalendar;

            _startCalendar.SelectedDate = StartDate;
            _endCalendar.SelectedDate = EndDate;

            _startCalendar.DateSelected += date => HandleDateSelection(date.Value, _startCalendar, _startCalendar, _endCalendar);
            _endCalendar.DateSelected += date => HandleDateSelection(date.Value, _endCalendar, _startCalendar, _endCalendar);

            _startCalendar.MonthOrYearChanged += () => 
            {
                _startCalendar.ClearSelection();
                _endCalendar.ClearSelection();
                // 추가적으로 필요한 초기화 코드가 있다면 이곳에...
            };
    
            _endCalendar.MonthOrYearChanged += () => 
            {
                _startCalendar.ClearSelection();
                _endCalendar.ClearSelection();
                // 추가적으로 필요한 초기화 코드가 있다면 이곳에...
            };
        }

        private static void OnSelectedStartDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue == null)
            { 
            DateRangeSelector dd = d as DateRangeSelector;

            dd._startCalendar.ClearSelectedItem();
            dd._startCalendar.ClearSelection();
            dd.SelectedStartDate = null;
            dd._startCalendar.SelectedDate = dd.StartDate;
            dd._endCalendar.SelectedDate = dd.EndDate;
        }
        }

        private static void OnSelectedEndDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue == null)
            {
                DateRangeSelector dd = d as DateRangeSelector;

                dd._endCalendar.ClearSelectedItem();
                dd._endCalendar.ClearSelection();
                dd.SelectedEndDate = null;
                dd._startCalendar.SelectedDate = dd.StartDate;
                dd._endCalendar.SelectedDate = dd.EndDate;
            }
        }

        private void HandleDateSelection(DateTime selectedDate, RangeCalendar sender, RangeCalendar startCalendar, RangeCalendar endCalendar)
        {
            if (!_lastSelectedDate.HasValue)
            {
                _lastSelectedDate = selectedDate;
                                
                startCalendar.ClearSelectedItem();
                endCalendar.ClearSelectedItem();

                startCalendar.ClearSelection();
                endCalendar.ClearSelection();

                SelectedStartDate = null;
                SelectedEndDate = null;
            }
            else
            {
                DateTime start, end;

                if (selectedDate < _lastSelectedDate.Value)
                {
                    start = selectedDate;
                    end = _lastSelectedDate.Value;
                }
                else
                {
                    start = _lastSelectedDate.Value;
                    end = selectedDate;
                }

                startCalendar.HighlightRange(start, end);
                endCalendar.HighlightRange(start, end);
                _lastSelectedDate = null;

                SelectedStartDate = start;
                SelectedEndDate = end;  
            }
        }

        internal void ClearStart()
        {
            _startCalendar.ClearSelectedItem();
            SelectedStartDate = null;
            _startCalendar.SelectedDate = StartDate;
            _endCalendar.SelectedDate = EndDate;
        }

        internal void ClearEnd()
        {
            _startCalendar.ClearSelectedItem();
            SelectedEndDate = null;
            _startCalendar.SelectedDate = StartDate;
            _endCalendar.SelectedDate = EndDate;

            _lastSelectedDate = null;
        }
    }
}