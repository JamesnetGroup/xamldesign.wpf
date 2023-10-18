# xamldesignwpf

![image](https://github.com/jamesnet214/xamldesignwpf/assets/52397976/b51b38cb-9ab9-4ef0-b68c-9f1f98866440)


## ToggleRadioSwitch

```xaml
<Style TargetType="{x:Type units:ToggleRadioSwitch}">
    <Setter Property="HorizontalAlignment" Value="Left"/>
    <Setter Property="VerticalAlignment" Value="Bottom"/>
    <Setter Property="Background" Value="#4B5563"/>
    <Setter Property="ToggleRadioSwitchCheckedBackground" Value="#1546A7"/>
    <Setter Property="ToggleRadioSwitchMouseOverBackground" Value="#1E67FA"/>
    <Setter Property="ToggleRadioSwitchEllipseBackground" Value="#FFFFFF"/>
    <Setter Property="Foreground" Value="{DynamicResource Button.Foreground}"/>
    <Setter Property="Cursor" Value="Hand"/>
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="{x:Type units:ToggleRadioSwitch}">
                <Border x:Name="border" 
                        Background="{TemplateBinding Background}"
                        BorderBrush="{TemplateBinding BorderBrush}"
                        BorderThickness="{TemplateBinding BorderThickness}"
                        CornerRadius="13"
                        Width="50" Height="26">
                    <Ellipse x:Name="ellipse" Margin="3 3 3 3"
                             Width="18" Height="18"
                             VerticalAlignment="Center"
                             HorizontalAlignment="Left"
                             Fill="{TemplateBinding ToggleRadioSwitchEllipseBackground}"/>
                </Border>
                <ControlTemplate.Triggers>
                    <Trigger Property="IsMouseOver" Value="True">
                        <Setter Property="Background" TargetName="border" Value="{Binding RelativeSource={RelativeSource TemplatedParent}, Path=ToggleRadioSwitchMouseOverBackground}"/>
                    </Trigger>
                    <Trigger Property="IsChecked" Value="True">
                        <Setter Property="HorizontalAlignment" TargetName="ellipse" Value="Right"/>
                        <Setter Property="Background" TargetName="border" Value="{Binding RelativeSource={RelativeSource TemplatedParent}, Path=ToggleRadioSwitchCheckedBackground}"/>
                    </Trigger>
                </ControlTemplate.Triggers>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```