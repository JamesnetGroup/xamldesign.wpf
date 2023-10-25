using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace XamlDesign.Wpf.Local.Models
{
    public class PropertyItem : INotifyPropertyChanged
    {
        public string Name { get; set; }
        private object _value;
        private object _originalObject;

        public object Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = ParseValue(value);
                    OnPropertyChanged();
                    UpdateOriginalObject();
                }
            }
        }

        public object OriginalObject
        {
            get { return _originalObject; }
            set
            {
                if (_originalObject != value)
                {
                    DetachDependencyPropertyChangedHandler();
                    _originalObject = value;
                    AttachDependencyPropertyChangedHandler();
                }
            }
        }

        public PropertyInfo PropertyInfo { get; set; }

        private void AttachDependencyPropertyChangedHandler()
        {
            if (OriginalObject is DependencyObject dependencyObject)
            {
                foreach (var property in OriginalObject.GetType().GetProperties())
                {
                    var descriptor = DependencyPropertyDescriptor.FromName(property.Name, OriginalObject.GetType(), OriginalObject.GetType());
                    if (descriptor != null)
                    {
                        descriptor.AddValueChanged(dependencyObject, OnDependencyPropertyChanged);
                    }
                }
            }
        }

        private void DetachDependencyPropertyChangedHandler()
        {
            if (OriginalObject is DependencyObject dependencyObject)
            {
                foreach (var property in OriginalObject.GetType().GetProperties())
                {
                    var descriptor = DependencyPropertyDescriptor.FromName(property.Name, OriginalObject.GetType(), OriginalObject.GetType());
                    if (descriptor != null)
                    {
                        descriptor.RemoveValueChanged(dependencyObject, OnDependencyPropertyChanged);
                    }
                }
            }
        }

        private void OnDependencyPropertyChanged(object sender, EventArgs e)
        {
            Value = PropertyInfo.GetValue(OriginalObject);
        }

        private void UpdateOriginalObject()
        {
            PropertyInfo.SetValue(OriginalObject, Value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private object ParseValue(object value)
        {
            if (value is string strValue)
            {
                Type propertyType = PropertyInfo.PropertyType;

                if (propertyType == typeof(Color))
                {
                    return (Color)ColorConverter.ConvertFromString(strValue);
                }
                else if (propertyType == typeof(Brush))
                {
                    return (Brush)new BrushConverter().ConvertFromString(strValue);
                }
                else if (propertyType == typeof(Thickness))
                {
                    return (Thickness)new ThicknessConverter().ConvertFromString(strValue);
                }
                else if (propertyType == typeof(int))
                {
                    return int.Parse(strValue);
                }
                else if (propertyType == typeof(double))
                {
                    return double.Parse(strValue);
                }
                else if (propertyType == typeof(bool))
                {
                    strValue = strValue.ToLower().Trim();
                    if (strValue == "true" || strValue == "1")
                        return true;
                    if (strValue == "false" || strValue == "0")
                        return false;
                    throw new ArgumentException($"'{strValue}' cannot be parsed as a bool.");
                }
                else if (propertyType == typeof(bool?))
                {
                    if (string.IsNullOrEmpty(strValue))
                        return null;

                    strValue = strValue.ToLower().Trim();
                    if (strValue == "true" || strValue == "1")
                        return true;
                    if (strValue == "false" || strValue == "0")
                        return false;
                    throw new ArgumentException($"'{strValue}' cannot be parsed as a bool.");
                }
                else if (propertyType == typeof(HorizontalAlignment))
                {
                    return (HorizontalAlignment)Enum.Parse(typeof(HorizontalAlignment), strValue);
                }
                else if (propertyType == typeof(Visibility))
                {
                    return (Visibility)Enum.Parse(typeof(Visibility), strValue);
                }
                else if (propertyType == typeof(VerticalAlignment))
                {
                    return (VerticalAlignment)Enum.Parse(typeof(VerticalAlignment), strValue);
                }
                // 기타 타입에 대한 변환 로직 추가...
            }

            return value;
        }
    }
}
