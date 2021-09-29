# Introduction 
This project is a workshop result for Selenium training and learning.  The premise was to start with a simple UI project and incorporate Selenium for automated UI tests.

## Goals
1. Learn Selenium basics
    - Libraries and dependencies
    - Project Setup
2. Get automated tests running and passing
    - NUnit is the preferred project template
3. Cross Browser Testing
4. Bonus - Define a clean architecture and project structure for the app

# Tools
- IDE
    - Visual Studio 2019 version 16.11.3 - Any edition (I used Community)
    - Visual Studio Code version 1.60
- Optional
    - Powershell: I found it helpful to run the project using the command line and then execute the tests through the IDE

# Key Libraries and Downloads
- .Net 5.0
- NUnit v3.13.1
- NUnit3TestAdapter v3.17.0
- [Selenium.WebDriver v4.0.0-rc1](https://www.nuget.org/packages/Selenium.WebDriver/4.0.0-rc1)
- [DotNetSeleniumExtras.PageObjects.Core v 3.12.0](https://www.nuget.org/packages/DotNetSeleniumExtras.PageObjects.Core)
- [DotNetSeleniumExtras.WaitHelpers v 3.11.0](https://www.nuget.org/packages/DotNetSeleniumExtras.WaitHelpers)
- [Edge Selenium WebDriver](https://developer.microsoft.com/en-us/microsoft-edge/tools/webdriver/)
- [Chrome Selenium WebDriver](https://chromedriver.chromium.org/downloads)

# Getting Started
1.	Ensure that you have all required tools installed - Visual Studio or VS Code
2.	Install optional tools if desired
3.	Install .net 5.0 framework is it is not already installed on the workstation

All other files and libraries will be included in the repository, so there is no need to download them or set them up

# Build
The solution will build and compile after restoring packages.  Use the menu to build or the keyboard shortcut (often F6).  You can also build the project via the command line using the command `dotnet build`

# Run
There are 5 projects in the solution:
- SeleniumUI
- SeleniumUI.MSTest.Automated.Tests
- SeleniumUI.NUnit.Automated.Tests
- SeleniumUI.XUnit.Automated.Tests
- TestDrivers

SeleniumUI should be the startup project and can be run through the IDE or via command line using the command `dotnet run`

# Test
There are a few key prerequisites before running the Automated Selenium tests
1. The UI must be running
2. Any browser web drivers: edge, chrome, etc... must be downloaded and within the bin\Debug\<framework> directory of the respective test project
`C:\<SolutionPath>\SeleniumUI.NUnit.Automated.Tests\bin\Debug\net5.0\chromedriver.exe`

There are a few options to run the tests:
1. Using the Visual Studio Text Explorer
2. Command line `dotnet test`

# Code References
- https://www.automatetheplanet.com/webdriver-net50/
- https://code-maze.com/automatic-ui-testing-selenium-asp-net-core-mvc/
- https://stackoverflow.com/questions/43780706/run-tests-on-multiple-browsers-in-parallel
- https://stackoverflow.com/questions/5028926/run-selenium-tests-in-multiple-browsers-one-after-another-from-c-sharp-nunit