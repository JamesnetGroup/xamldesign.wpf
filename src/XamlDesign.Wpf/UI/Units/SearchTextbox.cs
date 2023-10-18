using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace XamlDesign.Wpf.UI.Units;

public class SearchTextbox : ContentControl
{
    #region CornerRadius
    public CornerRadius CornerRadius
    {
        get { return (CornerRadius)GetValue (CornerRadiusProperty); }
        set { SetValue (CornerRadiusProperty, value); }
    }

    // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty CornerRadiusProperty =
        DependencyProperty.Register ("CornerRadius", typeof (CornerRadius), typeof (SearchTextbox), new PropertyMetadata (null));
    #endregion

    #region SearchCommand
    public ICommand SearchCommand
    {
        get { return (ICommand)GetValue (SearchCommandProperty); }
        set { SetValue (SearchCommandProperty, value); }
    }

    // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty SearchCommandProperty =
        DependencyProperty.Register ("SearchCommand", typeof (ICommand), typeof (SearchTextbox), new PropertyMetadata (null));
    #endregion

    static SearchTextbox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(SearchTextbox), new FrameworkPropertyMetadata(typeof(SearchTextbox)));
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate ();

        TextBox tb = GetTemplateChild ("PART_TB") as TextBox;
        Button bt = GetTemplateChild ("PART_BTN") as Button;

        bt.Click += (s, e) =>
        {
            SearchCommand?.Execute (tb.Text);
        };
    }
}
