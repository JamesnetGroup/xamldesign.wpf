using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using XamlDesign.Wpf.Local.Models;

namespace XamlDesign.Wpf.UI.Units
{
    public class PropertyList : ListBox
    {
        #region TargetObject

        public static readonly DependencyProperty TargetObjectProperty = DependencyProperty.Register(
            "TargetObject",
            typeof(object),
            typeof(PropertyList),
            new FrameworkPropertyMetadata(null, OnTargetObjectChanged));

        public object TargetObject
        {
            get { return GetValue(TargetObjectProperty); }
            set { SetValue(TargetObjectProperty, value); }
        }

        private static void OnTargetObjectChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var propertyList = d as PropertyList;
            propertyList?.UpdatePropertiesFromObject(e.NewValue);
        }
        #endregion

        static PropertyList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PropertyList), new FrameworkPropertyMetadata(typeof(PropertyList)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new PropertyListItem();
        }


        private void UpdatePropertiesFromObject(object obj)
        {
            var Properties = new ObservableCollection<PropertyItem>();
            if (obj == null) return;

            var type = obj.GetType();
            foreach (var prop in type.GetProperties())
            {
                if (prop.CanRead && prop.CanWrite)
                {
                    var propertyItem = new PropertyItem
                    {
                        Name = prop.Name,
                        OriginalObject = obj,
                        PropertyInfo = prop,
                        Value = prop.GetValue(obj),
                    };
                    Properties.Add(propertyItem);
                }
            }

            ItemsSource = Properties;
        }
    }
}
