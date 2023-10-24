using CommunityToolkit.Mvvm.ComponentModel;

namespace Jamesnet.Wpf.Component.Local.Models
{
    public partial class DayModel : ObservableObject
    {
        private bool _isSelected;

        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }

        private bool _isRange;

        public bool IsRange
        {
            get => _isRange;
            set => SetProperty(ref _isRange, value);
        }

        private bool _isStart;

        public bool IsStart
        {
            get => _isStart;
            set => SetProperty(ref _isStart, value);
        }

        private bool _isEnd;

        public bool IsEnd
        {
            get => _isEnd;
            set => SetProperty(ref _isEnd, value);
        }

        public int? DayValue { get; set; }
        public bool IsEmpty => !DayValue.HasValue;

        public string DayOfWeek { get; internal set; }
    }
}
