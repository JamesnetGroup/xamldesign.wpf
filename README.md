# XamlDesign.Wpf

![Library Logo](https://github.com/jamesnet214/xamldesignwpf/assets/54387261/d03074ca-4fd3-4566-9e09-dc4888758af3)

**XamlDesign.Wpf.UI.Units**는 WPF 애플리케이션을 위한 고성능의 오픈소스 UI 라이브러리입니다. 누겟 패키지로 제공되며, 다양한 컨트롤과 유틸리티를 포함하여 WPF 개발의 편리성과 효율성을 극대화해 줍니다.

## 🌟 주요 특징

- 🚀 **다양한 .NET 지원**: .NET Framework부터 .NET Core까지 모든 주요 버전에서 호환.
- 🎨 **유연한 커스터마이징**: 풍부한 DependencyProperty로 쉽게 UI를 커스터마이징.
- 🔗 **참조 라이브러리**: `Jamesnet.Wpf`, `CommunityToolkit.Mvvm`, 그리고 `Prism` 기반.

## 📜 Control List

### Buttons
| Control               | Base Type       | Description                                 | Namespace              | Template Link |
|:----------------------|:----------------|:--------------------------------------------|:-----------------------|:--------------|
| BorderedButton        | Button          | 버튼에 테두리 스타일이 추가된 컨트롤        | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/BorderedButton) |
| FilledButton          | Button          | 편평한 디자인의 버튼 컨트롤                 | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/FilledButton) |
| IconButton            | Button          | 아이콘 포함된 버튼 컨트롤                   | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/IconButton) |
| TextButton            | Button          | 텍스트만으로 구성된 버튼 컨트롤            | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/TextButton) |

### Calendar & Date Related
| Control               | Base Type       | Description                                 | Namespace              | Template Link |
|:----------------------|:----------------|:--------------------------------------------|:-----------------------|:--------------|
| CalendarComboBox      | ComboBox        | 달력 선택 기능이 추가된 콤보 박스           | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/CalendarComboBox) |
| CalendarListBox       | ListBox         | 달력 형태로 아이템을 표시하는 리스트 박스   | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/CalendarListBox) |
| CalendarListItem      | ListBoxItem     | 달력 리스트 박스의 개별 아이템             | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/CalendarListItem) |
| DateRangeSelector     | Control         | 날짜 범위를 선택하는 컨트롤                 | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/DateRangeSelector) |
| RangeCalendar         | Calendar        | 범위 선택이 가능한 달력 컨트롤              | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/RangeCalendar) |

### Text Input & Related
| Control               | Base Type       | Description                                 | Namespace              | Template Link |
|:----------------------|:----------------|:--------------------------------------------|:-----------------------|:--------------|
| SearchTextBox         | TextBox         | 검색 아이콘 포함된 텍스트 박스 컨트롤       | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/SearchTextBox) |
| SmartTextBox          | TextBox         | 입력에 따라 제안하는 스마트 텍스트 박스     | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/SmartTextBox) |

### Toggles & Selectors
| Control               | Base Type       | Description                                 | Namespace              | Template Link |
|:----------------------|:----------------|:--------------------------------------------|:-----------------------|:--------------|
| ComboBoxToggleButton  | ToggleButton    | 콤보 박스와 토글 버튼이 결합된 컨트롤       | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/ComboBoxToggleButton) |
| IconSwitch            | ToggleSwitch    | 아이콘 포함된 토글 스위치 컨트롤            | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/IconSwitch) |
| RadioExpander         | Expander        | 라디오 버튼 기능이 포함된 확장 컨트롤      | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/RadioExpander) |
| RageSlider            | Slider          | 주 rage 값을 표시하는 슬라이더             | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/RageSlider) |
| ToggleRadioSwitch     | ToggleSwitch    | 라디오 버튼 스위치 형태의 토글 컨트롤       | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/ToggleRadioSwitch) |
| ToggleSwitch          | ToggleSwitch    | 기본 토글 스위치 컨트롤                     | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/ToggleSwitch) |

### Separators
| Control               | Base Type       | Description                                 | Namespace              | Template Link |
|:----------------------|:----------------|:--------------------------------------------|:-----------------------|:--------------|
| HorizSeparator        | Separator       | 수평 방향의 구분선 컨트롤                   | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/HorizSeparator) |
| VerticalSeparator     | Separator       | 수직 방향의 구분선 컨트롤                   | Jamesnet.Wpf.Component | [View Template](https://github.com/jamesnet214/xamldesignwpf/wiki/VerticalSeparator) |



---

## 💡 시작하기

- **설치**:
  ```sh
  Install-Package XamlDesign.Wpf.UI.Units -Version [최신 버전 번호]
  ```

- [📖 Documentation (위키로 연결)](https://github.com/jamesnet214/xamldesignwpf/wiki)
- [🐞 이슈 제출하기](https://github.com/jamesnet214/xamldesignwpf/issues)

---

## 🤝 기여하기

모든 종류의 기여를 환영합니다! 이슈 제출, 풀 리퀘스트, 개선 제안 등 자유롭게 참여해주세요.

- [기여 가이드라인 보기](LINK_TO_CONTRIBUTING_GUIDE)

---

## ⚖ 라이선스

이 프로젝트는 MIT 라이선스 하에 배포됩니다. [라이선스 내용 확인하기](LICENSE).
