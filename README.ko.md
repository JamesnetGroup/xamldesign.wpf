# XamlDesign [![English](https://img.shields.io/badge/Language-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/Language-中文-red.svg)](README.zh-CN.md) [![한국어](https://img.shields.io/badge/Language-한국어-green.svg)](README.ko.md)

WPF 애플리케이션을 위한 학습 및 커스터마이징에 중점을 둔 고성능 오픈소스 UI 라이브러리

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnet214/xamldesignwpf.svg)](https://github.com/jamesnet214/xamldesignwpf/stargazers)
[![Issues](https://img.shields.io/github/issues/jamesnet214/xamldesignwpf.svg)](https://github.com/jamesnet214/xamldesignwpf/issues)
[![NuGet](https://img.shields.io/nuget/v/XamlDesign.Wpf.svg)](https://www.nuget.org/packages/XamlDesign.Wpf)

## 프로젝트 개요

XamlDesign은 WPF 애플리케이션을 위한 종합적인 UI 라이브러리로, 학습 강화와 광범위한 커스터마이징 옵션 제공을 목표로 설계되었습니다. 풍부한 DependencyProperty를 갖춘 다양한 커스텀 컨트롤을 제공하며, 유연한 테마 적용을 위해 DynamicResource를 활용합니다.


<img src="https://github.com/user-attachments/assets/ebce1246-55de-4c40-8576-26f0a081cf87" width="49%"/>
<img src="https://github.com/user-attachments/assets/3f62f639-94b6-42cf-b2ef-aee3201c103b" width="49%"/>
<img src="https://github.com/user-attachments/assets/a5dfd480-74f5-4350-9939-ac2336053d02" width="49%"/>
<img src="https://github.com/user-attachments/assets/4ea2ed96-08c3-485a-b5e7-687dd29e767b" width="49%"/>

## 주요 기능 및 구현 사항
#### 1. 커스텀 컨트롤 개발
- [x] 처음부터 구축된 광범위한 커스텀 컨트롤
- [x] 각 컨트롤에 대한 풍부한 DependencyProperty 세트
- [x] 사용자 정의 ControlTemplate 구현

#### 2. 테마 및 스타일링
- [x] 테마 적용을 위한 DynamicResource 활용
- [x] 쉬운 커스터마이징을 위한 유연한 스타일링 시스템
- [x] 모든 컨트롤에 걸친 일관된 디자인 언어

#### 3. WPF 모범 사례
- [x] MVVM 패턴 통합 시연
- [x] WPF 바인딩 및 커맨딩의 효율적인 사용
- [x] 고급 WPF 기술의 쇼케이스

#### 4. 학습 중심 설계
- [x] 교육 목적의 명확하고 잘 문서화된 코드
- [x] 실제 애플리케이션에서의 복잡한 WPF 개념 예시
- [x] 쉬운 이해와 확장을 위한 모듈식 아키텍처

#### 5. 성능 최적화
- [x] 효율적인 렌더링 및 리소스 관리
- [x] 부드러운 UI 상호작용을 위한 최적화된 컨트롤 템플릿

## 기술 스택
- .NET 8.0
- WPF (Windows Presentation Foundation)
- C# 10.0
- XAML

## 시작하기
### 필요 조건
- Visual Studio 2022 이상
- .NET 8.0 SDK

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="32%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="32%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="32%"/>

### 설치 및 사용
#### 1. NuGet을 통한 설치:

```
Install-Package XamlDesign -Version [최신 버전 번호]
```

#### 2. 프로젝트에 추가
- [x] XAML 파일에 참조 추가
- [x] 필요한 네임스페이스 가져오기

#### 3. XamlDesign 컨트롤 사용 시작
- [x] WPF 애플리케이션에 컨트롤 통합
- [x] 제공된 DependencyProperty를 사용하여 커스터마이즈
- [x] DynamicResource를 사용하여 테마 적용

## 주요 컨트롤 목록
- **버튼**: BorderedButton, FilledButton, IconButton, TextButton, BadgeButton
- **캘린더 및 날짜**: CalendarComboBox, CalendarListBox, DateRangeSelector, RangeCalendar
- **입력 컨트롤**: SearchTextBox, SmartTextBox
- **토글 및 선택자**: ComboBoxToggleButton, IconSwitch, RadioExpander, RageSlider
- **그 외 다수...**

## 학습 기회
XamlDesign은 WPF 개발자들에게 풍부한 학습 경험을 제공합니다:
1. **커스텀 컨트롤 개발**: 복잡하고 재사용 가능한 WPF 컨트롤 생성 방법 학습
2. **DependencyProperty 사용**: DependencyProperty의 힘과 유연성 이해
3. **DynamicResource를 이용한 테마 적용**: WPF 애플리케이션에서 동적 테마 적용 마스터
4. **XAML과 C# 통합**: WPF에서 XAML과 C#을 결합하는 모범 사례 확인
5. **성능 최적화**: 효율적인 WPF UI 생성 기법 학습

## 기여하기
XamlDesign에 대한 기여를 환영합니다! 이슈 제출, 풀 리퀘스트 생성 또는 개선 제안 등 자유롭게 참여해 주세요.

## 라이선스
이 프로젝트는 MIT 라이선스 하에 배포됩니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 연락처
- 웹사이트: https://jamesnet.dev
- 이메일: james@jamesnet.dev, vickyqu115@hotmail.com

XamlDesign과 함께 고급 WPF 컨트롤 개발의 세계를 탐험해보세요!
