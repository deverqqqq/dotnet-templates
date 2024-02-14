# dotnet-templates

# 介紹

這個儲存庫包含下面內容。
- 研究 dotnet template 的 Sample
- 我開發的範本
  - FakeLinqpadConsole: 取代 Linqpad 的專案範本，可以用來做測試和 POC。
  - WebApi-ThreeLayer: 三層架構的 WebApi 範本，需要使用此架構建立 WebApi 服務，可以快速產生大致結構。

## 開始

### 開始之前

在開始之前，請確認下面工具是否已經有正確安裝。

- SDK: .NET 8.0 或更高版本
- Visual Studio 2022 或更高版本

### 安装

1. 透過 NugetPackage 安裝

    ```bash
    dotnet new --install deverqqqq.Templates
    ```

    [套件連結](https://www.nuget.org/packages/deverqqqq.Templates/)

2. 透過原始碼安裝
   
    ```bash
    # 切換到要使用的範本資料夾內
    # ex: working\content\WebApi.ThreeLayer

    # 本地安裝
    dotnet new install .\
    ```

## 使用说明

這個專案主要是用來整理一些個人使用的範本模版，你可以根據自身需求做調整。   

## 功能特性

1. 節省每次重複安裝相同套件的時間。
2. 節省每次建立新服務都需求從頭建置專案結構的時間。
3. 降低團隊溝通開發架構的成本。

## 參考資料

1. [MSLearn](https://learn.microsoft.com/zh-tw/dotnet/core/tutorials/cli-templates-create-item-template)
2. [Templating wiki](https://github.com/dotnet/templating/wiki)  
3. [aspnetcore](https://github.com/dotnet/aspnetcore/tree/main/src/ProjectTemplates)
