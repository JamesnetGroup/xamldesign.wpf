# xamldesignwpf

![image](https://github.com/jamesnet214/xamldesignwpf/assets/54387261/d03074ca-4fd3-4566-9e09-dc4888758af3)

**xamldesignwpf**는 WPF 애플리케이션을 위한 최적화된 오픈 소스 라이브러리입니다. 이 라이브러리는 누겟 패키지로도 제공되며, 다양한 컨트롤과 유틸리티를 통해 개발의 편리성을 높여줍니다.

## 주요 특징

- **다양한 .NET 지원**: .NET Framework부터 .NET Core까지, 모든 닷넷 버전에서 호환성 있게 설계되었습니다.
- **유연한 커스터마이징**: 각 컨트롤은 풍부한 DependencyProperty를 포함하며, 별도의 템플릿 커스터마이징 없이도 유연하게 디자인 변경이 가능합니다.
- **참조 라이브러리**: 이 라이브러리는 `Jamesnet.Wpf`, `CommunityToolkit.Mvvm`, 그리고 `Prism` 등의 라이브러리를 기반으로 합니다.

## Control List

| Control               | Base Type       | Description                                 | Namespace              | Template Link |
|:----------------------|:----------------|:--------------------------------------------|:-----------------------|:--------------|
| BorderedButton        | Button          | 버튼에 테두리 스타일이 추가된 컨트롤        | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/BorderedButton) |
| FilledButton          | Button          | 편평한 디자인의 버튼 컨트롤                 | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/FilledButton) |
| CalendarComboBox      | ComboBox        | 달력 선택 기능이 추가된 콤보 박스           | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/CalendarComboBox) |
| CalendarListBox       | ListBox         | 달력 형태로 아이템을 표시하는 리스트 박스   | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/CalendarListBox) |
| CalendarListItem      | ListBoxItem     | 달력 리스트 박스의 개별 아이템             | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/CalendarListItem) |
| ComboBoxToggleButton  | ToggleButton    | 콤보 박스와 토글 버튼이 결합된 컨트롤       | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/ComboBoxToggleButton) |
| DateRangeSelector     | Control         | 날짜 범위를 선택하는 컨트롤                 | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/DateRangeSelector) |
| HorizSeparator        | Separator       | 수평 방향의 구분선 컨트롤                   | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/HorizSeparator) |
| IconButton            | Button          | 아이콘 포함된 버튼 컨트롤                   | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/IconButton) |
| IconCheckBox          | CheckBox        | 아이콘 포함된 체크 박스 컨트롤              | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/IconCheckBox) |
| IconSwitch            | ToggleSwitch    | 아이콘 포함된 토글 스위치 컨트롤            | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/IconSwitch) |
| RadioExpander         | Expander        | 라디오 버튼 기능이 포함된 확장 컨트롤      | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/RadioExpander) |
| RageSlider            | Slider          | 주 rage 값을 표시하는 슬라이더             | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/RageSlider) |
| RangeCalendar         | Calendar        | 범위 선택이 가능한 달력 컨트롤              | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/RangeCalendar) |
| SearchTextBox         | TextBox         | 검색 아이콘 포함된 텍스트 박스 컨트롤       | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/SearchTextBox) |
| SmartTextBox          | TextBox         | 입력에 따라 제안하는 스마트 텍스트 박스     | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/SmartTextBox) |
| TextButton            | Button          | 텍스트만으로 구성된 버튼 컨트롤            | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/TextButton) |
| ToggleRadioSwitch     | ToggleSwitch    | 라디오 버튼 스위치 형태의 토글 컨트롤       | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/ToggleRadioSwitch) |
| ToggleSwitch          | ToggleSwitch    | 기본 토글 스위치 컨트롤                     | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/ToggleSwitch) |
| VerticalSeparator     | Separator       | 수직 방향의 구분선 컨트롤                   | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/VerticalSeparator) |


---

이 Readme를 통해 개발자들이 라이브러리의 주요 특징과 제공하는 컨트롤들에 대해 쉽게 이해하고 활용할 수 있을 것입니다.
