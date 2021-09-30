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
3.	Install .net 5.0 framework if it is not already installed on the workstation

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

# Run Settings
This solution contains a .runsettings file.  The purpose of the .runsettings is parameterize inputs for testing to accomodate different environments or scenarios.  For example, automating the tests between a QA and PROD environment will likely need to parameterize the app url.  the .runsettings is one way to accomplish that.

### Solution Config and Solution Wide Files
Within Visual Studio, the only file named ".runsettings" can be auto detected and only when it is in the root director of the solution.  In this case it is auto detected within the Selenium_Learn directory
Visual Studio must be configuted to auto Detect the file
`Test > Configure Run Settings > Auto Detect runsettings Files`

You can also manually select a different run settings file within the same menu
`Test > Configure Run Settings > Select Solution Wide runsettings File`

For more information on runsettings visit [Run Settings](https://docs.microsoft.com/en-us/visualstudio/test/configure-unit-tests-by-using-a-dot-runsettings-file?view=vs-2019#create-a-run-settings-file-and-customize-it)

### Runsettings through the DotNet CLI
Runsettings can also be set through the cli via the -s or --settings parameter of the dotnet test command.  This could be useful if needing to run the tests using a headless browser, like would be needed in a build pipeline.
`dotnet test --settings=<filename>`
`dotnet test --settings=.runsettings`

Visit [dotnet test cli](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test) for more information

# Code References
- https://www.automatetheplanet.com/webdriver-net50/
- https://code-maze.com/automatic-ui-testing-selenium-asp-net-core-mvc/
- https://stackoverflow.com/questions/43780706/run-tests-on-multiple-browsers-in-parallel
- https://stackoverflow.com/questions/5028926/run-selenium-tests-in-multiple-browsers-one-after-another-from-c-sharp-nunit
- https://github.com/nunit/nunit3-vs-adapter/tree/8a9b8a38b7f808a4a78598542ddaf557950c6790/demo
- https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test#examples
- https://docs.microsoft.com/en-us/visualstudio/test/configure-unit-tests-by-using-a-dot-runsettings-file?view=vs-2019#create-a-run-settings-file-and-customize-it