using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using XamlDesign.Wpf.Local.Models;

namespace XamlDesign.Wpf.UI.Units
{
    public class RangeCalendar : Control
    {
        static RangeCalendar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RangeCalendar), new FrameworkPropertyMetadata(typeof(RangeCalendar)));
        }

        public static readonly DependencyProperty SelectedDateProperty =
            DependencyProperty.Register("SelectedDate", typeof(DateTime?), typeof(RangeCalendar), new FrameworkPropertyMetadata(null, OnSelectedDateChanged));

        public static readonly DependencyProperty SelectedYearProperty =
            DependencyProperty.Register("SelectedYear", typeof(int), typeof(RangeCalendar), new PropertyMetadata(DateTime.Now.Year, OnDatePartChanged));

        public static readonly DependencyProperty SelectedMonthProperty =
            DependencyProperty.Register("SelectedMonth", typeof(int), typeof(RangeCalendar), new PropertyMetadata(DateTime.Now.Month, OnDatePartChanged));

        public static readonly DependencyProperty DaysProperty =
            DependencyProperty.Register("Days", typeof(ObservableCollection<DayModel>), typeof(RangeCalendar), new PropertyMetadata(null));
        private ListBox _daysListBox;

        public DateTime? SelectedDate
        {
            get { return (DateTime?)GetValue(SelectedDateProperty); }
            set { SetValue(SelectedDateProperty, value); }
        }

        public int SelectedYear
        {
            get { return (int)GetValue(SelectedYearProperty); }
            set { SetValue(SelectedYearProperty, value); }
        }

        public int SelectedMonth
        {
            get { return (int)GetValue(SelectedMonthProperty); }
            set { SetValue(SelectedMonthProperty, value); }
        }

        public ObservableCollection<DayModel> Days
        {
            get { return (ObservableCollection<DayModel>)GetValue(DaysProperty); }
            set { SetValue(DaysProperty, value); }
        }

        public event Action<DateTime?> DateSelected;
        public event Action MonthOrYearChanged;

        public RangeCalendar()
        {
            GenerateDays();
        }

        public void HighlightRange(DateTime startDate, DateTime endDate)
        {
            foreach (var day in Days)
            {
                if (day.DayValue.HasValue)
                {
                    DateTime currentDay = new DateTime(SelectedYear, SelectedMonth, day.DayValue.Value);

                    if (currentDay == startDate)
                    {
                        day.IsStart = true;
                        day.IsEnd = false;
                    }
                    else if (currentDay == endDate)
                    {
                        day.IsStart = false;
                        day.IsEnd = true;
                    }
                    else if (currentDay > startDate && currentDay < endDate)
                    {
                        day.IsStart = false;
                        day.IsEnd = false;
                    }
                    else
                    {
                        day.IsStart = false;
                        day.IsEnd = false;
                    }

                    day.IsRange = (currentDay >= startDate && currentDay <= endDate);
                }
            }
        }


        public void ClearSelection()
        {
            foreach (var day in Days)
            {
                day.IsRange = false;
            }
        }

        public void ClearSelectedItem()
        {

            foreach (var day in Days)
            {
                day.IsSelected = false;
                day.IsStart = false;
                day.IsEnd = false;
                _daysListBox.SelectedItem = null; ;
            }
        }

        private static void OnSelectedDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RangeCalendar calendar && e.NewValue is DateTime newDate)
            {
                calendar.SelectedYear = newDate.Year;
                calendar.SelectedMonth = newDate.Month;
                calendar.GenerateDays();
            }
        }

        private static void OnDatePartChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RangeCalendar control)
            {
                control.GenerateDays();
            }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            var yearComboBox = GetTemplateChild("PART_YearComboBox") as ComboBox;
            var monthComboBox = GetTemplateChild("PART_MonthComboBox") as ComboBox;
            _daysListBox = GetTemplateChild("PART_DaysListBox") as ListBox;

            _daysListBox.SelectionChanged += (s, e) =>
            {
                if (_daysListBox.SelectedItem is DayModel selectedDay)
                {
                    DaySelected(selectedDay.DayValue);
                    selectedDay.IsSelected = true;
                }
            };

            yearComboBox.ItemsSource = Enumerable.Range(DateTime.Now.Year - 10, 20);
            monthComboBox.DisplayMemberPath = "MonthName";
            monthComboBox.SelectedValuePath = "MonthNumber";
            monthComboBox.ItemsSource = GetMonths();

            yearComboBox.SelectionChanged += (s, e) => UpdateDays(_daysListBox, yearComboBox, monthComboBox);
            monthComboBox.SelectionChanged += (s, e) => UpdateDays(_daysListBox, yearComboBox, monthComboBox);
        }

        private void UpdateDays(ListBox listBox, ComboBox yearCombo, ComboBox monthCombo)
        {
            if (yearCombo.SelectedItem is int year && monthCombo.SelectedItem is int month)
            {
                MonthOrYearChanged?.Invoke();

                SelectedYear = year;
                SelectedMonth = month;
                GenerateDays();
                listBox.ItemsSource = Days;
            }
        }

        private void GenerateDays()
        {
            var daysList = new ObservableCollection<DayModel>();
            var firstDayOfMonth = new DateTime(SelectedYear, SelectedMonth, 1);
            var startDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

            for (int i = 0; i < startDayOfWeek; i++)
            {
                daysList.Add(new DayModel());
            }

            int daysInMonth = DateTime.DaysInMonth(SelectedYear, SelectedMonth);
            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime currentDay = new DateTime(SelectedYear, SelectedMonth, day);
                string twoLetterDayOfWeek = currentDay.DayOfWeek.ToString().Substring(0, 2).ToUpper();

                daysList.Add(new DayModel { DayValue = day, DayOfWeek = twoLetterDayOfWeek });
            }

            Days = daysList;
        }


        private void DaySelected(int? day)
        {
            if (day.HasValue)
            {
                DateSelected?.Invoke(new DateTime(SelectedYear, SelectedMonth, day.Value));
            }
        }

        private ObservableCollection<MonthModel> GetMonths()
        {
            var months = new ObservableCollection<MonthModel>();
            for (int i = 1; i <= 12; i++)
            {
                months.Add(new MonthModel
                {
                    MonthNumber = i,
                    MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(i)
                });
            }
            return months;
        }
    }
}
