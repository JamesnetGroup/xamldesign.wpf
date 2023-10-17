using CommunityToolkit.Mvvm.ComponentModel;

namespace XamlDesign.Wpf.Local.Models
{
    public partial class DayModel : ObservableObject
    {
        [ObservableProperty]
        private bool _isSelected;
        [ObservableProperty]
        private bool _isRange;
        [ObservableProperty]
        private bool _isStart;
        [ObservableProperty]
        private bool _isEnd;

        public int? DayValue { get; set; }
        public bool IsEmpty => !DayValue.HasValue;

        public string DayOfWeek { get; internal set; }
    }
}
