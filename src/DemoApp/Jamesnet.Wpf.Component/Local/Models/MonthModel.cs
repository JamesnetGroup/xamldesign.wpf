namespace Jamesnet.Wpf.Component.Local.Models
{
    public class MonthModel
    {
        public int MonthNumber { get; set; }
        public string MonthName { get; set; }

        public override string ToString()
        {
            return MonthName;
        }
    }
}
