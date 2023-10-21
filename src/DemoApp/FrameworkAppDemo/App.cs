using FrameworkAppDemo.UI.Views;
using Jamesnet.Wpf.Controls;
using System;
using System.Windows;

namespace FrameworkAppDemo
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new TestWindow();
        }

        public App()
        {
            ResourceDictionary myResourceDictionary = new ResourceDictionary();

            myResourceDictionary.Source = new Uri("/FrameworkAppDemo;component/Themes/Default.xaml", UriKind.RelativeOrAbsolute);
            this.Resources.MergedDictionaries.Add(myResourceDictionary);
        }
    }
}